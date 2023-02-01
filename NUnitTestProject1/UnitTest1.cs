using NUnit.Framework;
using Kursovaya;
using System.Collections.Generic;

namespace NUnitTestProject1
{
    public class Tests
    {
        BinarySearch BS = new BinarySearch();
        string[] name = new string[]{"�������� �������", "������� �������", "������ �����", "������� �����", "�������� ����",
                                    "������� ����", "������������ ������", "������� ������", "�������� ����", "������ �����"};

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int a = 0;
            int b = BS.Find(name, "�������� �������");
            Assert.Pass(a.ToString(), b.ToString());
        }
        [Test]
        public void Test2()
        {
            int a = 9;
            int b = BS.Find(name, "������ �����");
            Assert.Pass(a.ToString(), b.ToString());
        }
        [Test]
        public void Test3()
        {
            int a = -1;
            int b = BS.Find(name, "������ ������");
            Assert.Pass(a.ToString(), b.ToString());
        }
        [Test]
        public void Test4()
        {
            int a = 7;
            int b = BS.Find(name, "������� ������");
            Assert.Pass(a.ToString(), b.ToString());
        }
    }
}