using System;
using System.Diagnostics;
using CFNET;
using CFNET.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CFNet.Tests
{
    [TestClass]
    public class CFActionTests
    {
        [TestMethod]
        public void CheckSerializationOfFieldsForUser()
        {
            var unuqueId = Guid.NewGuid().ToString();
            var newUser = new CFUser("test@test.com", "weeeeee", "pwdpwd!", unuqueId);

            var paramLsit = newUser.ToParams();

            Assert.AreEqual(paramLsit.Count, 6);
            Assert.AreEqual(paramLsit["cloudflare_email"], "test@test.com");
            Assert.AreEqual(paramLsit["cloudflare_username"], "weeeeee");
            Assert.AreEqual(paramLsit["cloudflare_pass"], "pwdpwd!");
            Assert.AreEqual(paramLsit["unique_id"], unuqueId);
            Assert.AreEqual(paramLsit["act"], "user_create");
        }

    }
}
