using System;
using System.Collections.Generic;
using Xunit;

namespace Statistics.Tests
{
    public class AverageTest
    {
        [Fact]
        public void TestMeanOfTwoNumbers()
        {
            List<int> numbers = new List<int> { 1, 5 };
            double expected = 3;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfFiveNumbers()
        {
            List<int> numbers = new List<int> { 1, 5, 7, 8, 9 };
            double expected = 6;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfZeroNumbers()
        {
            List<int> numbers = new List<int> {};
            double expected = "Invalid List";
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMedianForOddNumberOfElements()
        {
            double[] numbers = new double[4,6,7];
            double expected = 6;
            Median median = new Median();

            double actual = median.GetMedian(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMedianForEvenNumberOfElements()
        {
            double[] numbers = new double[4,6,7,9];
            double expected = 6.5;
            Median median = new Median();

            double actual = median.GetMedian(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMedianForNoElements()
        {
            double[] numbers = new double[4,6,7,9];
            double expected = "Array empty";
            Median median = new Median();

            double actual = median.GetMedian(numbers);

            Assert.Equal(expected, actual);
        }
    }
}
