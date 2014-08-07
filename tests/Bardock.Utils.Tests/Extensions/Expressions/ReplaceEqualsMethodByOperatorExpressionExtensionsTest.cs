﻿using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using Bardock.Utils.Extensions;
using Xunit;

namespace Bardock.Utils.Tests.Extensions
{
    public class ReplaceEqualsMethodByOperatorExpressionExtensionsTest
    {
        [Fact]
        public void ReplaceEqualsMethodByOperator_Right_Constant()
        {
            Expression<Func<string, bool>> exp = (x => new DateTime(2000, 1, 1).Year.Equals(2000));
            var r = exp.ReplaceEqualsMethodByOperator();
            Assert.Equal("x => (new DateTime(2000, 1, 1).Year == 2000)", r.ToString());
        }

        [Fact]
        public void ReplaceEqualsMethodByOperator_Right_Variable()
        {
            var rightValue = 2000;
            Expression<Func<string, bool>> exp = (x => new DateTime(2000, 1, 1).Year.Equals(rightValue));
            var r = exp.ReplaceEqualsMethodByOperator();
            Assert.Equal("x => (new DateTime(2000, 1, 1).Year == rightValue)", SerializeExpression(r));
        }

        private string SerializeExpression(Expression expr)
        {
            return Regex.Replace(expr.ToString(), @"value\([^)]*\)\.", "");
        }
    }
}