﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Bardock.Utils.Extensions;
using Bardock.Utils.Globalization;

namespace Bardock.Utils.Tests.Extensions
{
    public class GenericExtensionsTest
    {
        [Fact]
        public void Is_True()
        {
            var r = 3.Is(predicate: x => x == 3);
            Assert.Equal(true, r);
        }

        [Fact]
        public void Is_False()
        {
            var r = 3.Is(predicate: x => x == 4);
            Assert.Equal(false, r);
        }

        [Fact]
        public void In_Empty()
        {
            var r = 3.In();
            Assert.Equal(false, r);
        }

        [Fact]
        public void In_Success_Unique()
        {
            var r = 3.In(3);
            Assert.Equal(true, r);
        }

        [Fact]
        public void In_Success_Many()
        {
            var r = 3.In(1, 2, 3);
            Assert.Equal(true, r);
        }

        [Fact]
        public void In_Success_ManyAndDuplicated()
        {
            var r = 3.In(1, 2, 3, 4, 3);
            Assert.Equal(true, r);
        }

        [Fact]
        public void In_Fail_Unique()
        {
            var r = 3.In(4);
            Assert.Equal(false, r);
        }

        [Fact]
        public void In_Fail_Many()
        {
            var r = 3.In(1, 2, 4);
            Assert.Equal(false, r);
        }

        [Fact]
        public void Apply_True()
        {
            var r = 3.Apply(x => ++x, when: true);
            Assert.Equal(4, r);
        }

        [Fact]
        public void Apply_False()
        {
            var r = 3.Apply(x => x++, when: false);
            Assert.Equal(3, r);
        }

        [Fact]
        public void Apply_Project_True()
        {
            var r = 3.Apply(x => x.ToString(), when: true);
            Assert.Equal("3", r);
        }

        [Fact]
        public void Apply_Project_False()
        {
            var r = 3.Apply(x => x.ToString(), when: false);
            Assert.Equal(null, r);
        }

        [Fact]
        public void Apply_Project_True_Default()
        {
            var r = 3.Apply(x => x.ToString(), when: true, @default: "X");
            Assert.Equal("3", r);
        }

        [Fact]
        public void Apply_Project_False_Default()
        {
            var r = 3.Apply(x => x.ToString(), when: false, @default: "X");
            Assert.Equal("X", r);
        }
    }
}
