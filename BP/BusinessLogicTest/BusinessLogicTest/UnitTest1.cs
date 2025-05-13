using BusinessLogic.Activation;
using BusinessLogic.SMS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SR;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BusinessLogicTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void InsertActivationTest()
        {
            var result = new Activation_BL().InsertActivation(new DataModel.ViewModel.Activation_VM
            {
                PhoneNo = "09380458367"
            });
            Assert.IsTrue(true);
        }

        private readonly SmsPanel _smsService;
        [TestMethod]
        public void SMSTest()
        {
            //var result = new SmsPanel(new DataModel.SRModel.SmsConfig_VM
            //{
            //    Username = "09380458367",
            //    Password = "2809e415-564d-4009-a2ac-6753b234ca5a",
            //    SenderNumber = "9850002710058367",
            //}).SendSmsAsync(
            //   "09386339929",
            //   "واسه اینکه اطلاعاتی که ازت هک کردم رو وایرال نکنم باید بهم 1 میلیارد بدی همچنین سعی نکن باهام تماس بگیری خودم بهت پیام میدم");

            //result.Wait();

            //Assert.IsTrue(result.IsCompleted);
        }

        [TestMethod]
        public void SMS_BLTest()
        {
            var result = new Sms_BL().SendSms(new DataModel.ViewModel.Sms_VM
            {
                PhoneNo = "09380458367",
                Message = "test"
            });

            Assert.IsNotNull(result);
        }

        //[TestMethod]
        //public void HttpClientTest()
        //{
        //    var result = new SmsPanel(new DataModel.SRModel.SmsConfig_VM { }).HttpClient();
        //    result.Wait();

        //    Assert.IsTrue(result.IsCompleted);
        //}
    }
}
