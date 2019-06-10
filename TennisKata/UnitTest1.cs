using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisKata
{
    public class Tennis
    {
        public string Score(int a, int b)
        {
            if (a == b)
            {
                switch (a)

                {
                    case 0:
                        return "Love All";

                    case 15:
                        return "Fifteen All";

                    case 30:
                        return "Thirty All";

                    case 40:
                        return "Forty All";
                }
            }

            if (a > b)
            {
                switch (a)
                {
                    case 15:
                        return "Fifteen Love";

                    case 30:
                        switch (b)
                        {
                            case 0:
                                return "Thirty Love";
                        }
                        return "Thirty Fifteen";

                    case 40:
                        switch (b)
                        {
                            case 0:
                                return "Forty Love";

                            case 15:
                                return "Forty Fifteen";
                        }
                        return "Forty Thirty";
                }

                if (a > 40)
                    return "Player1 advance";
            }

            if (a < b)
            {
                switch (a)

                {
                    case 0:
                        switch (b)
                        {
                            case 15:
                                return "Love Fifteen";

                            case 30:
                                return "Love Thirty";
                        }

                        return "Love Forty";

                    case 15:
                        switch (b)
                        {
                            case 30:
                                return "Fifteen Thirty";
                        }
                        return "Fifteen Forty";

                    case 30:
                        return "Thirty Forty";
                }

                if (b > 40)
                    return "Player2 advance";
            }
            return null;
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FifteenAll()
        {
            var tennis = new Tennis();
            tennis.Score(15, 15);
        }

        [TestMethod]
        public void FifteenLove()
        {
            var tennis = new Tennis();
            var score = tennis.Score(15, 0);
            Assert.AreEqual("Fifteen Love", score);
        }

        [TestMethod]
        public void FifteenThirty()
        {
            var tennis = new Tennis();
            var score = tennis.Score(15, 30);
            Assert.AreEqual(15, 30);
        }

        [TestMethod]
        public void LoveAll()
        {
            var tennis = new Tennis();
            var score = tennis.Score(0, 0);
            Assert.AreEqual("Love All", score);
        }

        [TestMethod]
        public void LoveFifteen()
        {
            var tennis = new Tennis();
            var score = tennis.Score(0, 15);
            Assert.AreEqual("Love Fifteen", score);
        }

        [TestMethod]
        public void ThirtyAll()
        {
            var tennis = new Tennis();
            var score = tennis.Score(30, 30);
            Assert.AreEqual("Thirty All", score);
        }

        [TestMethod]
        public void ThirtyFifteen()
        {
            var tennis = new Tennis();
            var score = tennis.Score(30, 15);
            Assert.AreEqual("Thirty Fifteen", score);
        }
    }
}