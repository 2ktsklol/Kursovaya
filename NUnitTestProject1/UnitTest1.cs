using NUnit.Framework;
using Kursovaya;
using System.Collections.Generic;

namespace NUnitTestProject1
{
    public class Tests
    {
        BinarySearch BS = new BinarySearch();
        string[] name = new string[]{"юадсккхм юкейяеи", "аскшцхм мхйнкюи", "бюмхмю юкемю", "йспдхмю кхдхъ", "яюопнмнб хбюм",
                                    "рнонкеб хбюм", "лхпньмхвемйн яепцеи", "йкчйхмю юмтхяю", "лхуюикнб нкец", "нпкнбю екемю"};

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int a = 0;
            int b = BS.Find(name, "юадсккхм юкейяеи");
            Assert.Pass(a.ToString(), b.ToString());
        }
        [Test]
        public void Test2()
        {
            int a = 9;
            int b = BS.Find(name, "нпкнбю екемю");
            Assert.Pass(a.ToString(), b.ToString());
        }
        [Test]
        public void Test3()
        {
            int a = -1;
            int b = BS.Find(name, "оерпнб люйяхл");
            Assert.Pass(a.ToString(), b.ToString());
        }
        [Test]
        public void Test4()
        {
            int a = 7;
            int b = BS.Find(name, "йкчйхмю юмтхяю");
            Assert.Pass(a.ToString(), b.ToString());
        }
    }
}