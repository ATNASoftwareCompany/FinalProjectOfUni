using DataModel.SRModel;
using DataModel.ViewModel;
using SR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.SMS
{
    public partial class Sms_BL
    {
        public BaseResult_VM SendSms(Sms_VM inputModel)
        {
            try
            {
                var result = SendSmsAsync(inputModel);
                if (!(bool)result.Result)
                {
                    return new BaseResult_VM(null, -1, "خطا در ارسال پیامک", DataModel.Enum.ErrorType.Error);
                }
            }
            catch (Exception)
            {
                return new BaseResult_VM(null, -1, "خطا در ارسال پیامک", DataModel.Enum.ErrorType.Error);
            }

            return new BaseResult_VM(null, 0, "پیامک با موفقیت ارسال شد\n لطفا کد اعتبارسنجی دریافتی را جهت احراز هویت وارد نمایید", DataModel.Enum.ErrorType.Sussess);
        }

        private BaseResult_VM SendSmsAsync(Sms_VM inputModel)
        {
            try
            {
                var result = new SmsPanel(new SmsConfig_VM
                {
                    Username = "09380458367",
                    Password = "2809e415-564d-4009-a2ac-6753b234ca5a",
                }).SendSmsAsync(inputModel);
                result.Wait();

                return new BaseResult_VM(result.IsCompleted, 0, result.Result, DataModel.Enum.ErrorType.Sussess);
            }
            catch (Exception)
            {
                return new BaseResult_VM(null, -1, "خطا در ارسال پیامک", DataModel.Enum.ErrorType.Error);
            }
        }
    }
}
