using Microsoft.VisualStudio.TestTools.UnitTesting;
using YetAnotherMinesweeper.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetAnotherMinesweeper.ViewModel.UnitTests
{
    [TestClass()]
    public class Minefield_Tests
    {
        [TestMethod()]
        public void GetIndexesAround_Test_01()
        {
            PrivateObject privateHelperObject = new PrivateObject(new Minefield(3, 3, 0));
            List<int> expected = (new List<int> { 0, 1, 4, 6, 7 });
            expected.Sort();
            List<int> actual = (List<int>)privateHelperObject.Invoke("GetIndexesAround", 0, 1);
            actual.Sort();
            CollectionAssert.AreEqual(expected, actual);
        }
 
        [TestMethod()]
        public void GetIndexesAround_Test_11()
        {
            PrivateObject privateHelperObject = new PrivateObject(new Minefield(3, 3, 0));
            List<int> expected = (new List<int> { 0,1,2,3,5,6,7,8 });
            expected.Sort();
            List<int> actual = (List<int>)privateHelperObject.Invoke("GetIndexesAround", 1, 1);
            actual.Sort();
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}