using BusinessLogic.SMS;
using DataModel.Enum;
using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Activation
{
    public partial class Activation_BL
    {
        public BaseResult_VM UserAuthentication(string phoneNo)
        {
            try
            {
                var result = InsertActivation(new Activation_VM
                {
                    PhoneNo = phoneNo,
                    RemainingTime = DateTime.Now.AddMinutes(3),
                    IsDelete = false,
                    InsertDate = DateTime.Now,
                    Status = (int)BStatus.Active,
                });
                if (result.ErrorCode != 0)
                {
                    return result;
                }

                result = new Sms_BL().SendSms(new Sms_VM
                {
                    PhoneNo = phoneNo,
                    Message = "شرکت آرمان توسعه نرم افزار ایرانیان \n کد احراز هویت ثبت نام شما:" + result.Result.ToString()
                });

                return result;
            }
            catch (Exception)
            {
                return new BaseResult_VM(null, -1, "خطا در عملیات تولید کد احراز هویت", ErrorType.Error);
            }
        }
    }
}
