using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using See3.Common.Music;

namespace See3.Tests
{
    [TestClass]
    public class BasicTests
    {
        [TestMethod]
        public void InitializeArtist()
        {
            var artist = new Artist();
        }
    }
}
