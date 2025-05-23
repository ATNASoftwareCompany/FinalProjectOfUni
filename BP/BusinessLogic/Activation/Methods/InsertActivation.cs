﻿using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Activation
{
    public partial class Activation_BL
    {
        public BaseResult_VM InsertActivation(Activation_VM inputModel)
        {
            if (inputModel == null)
            {
                return new BaseResult_VM(null, -1, "لطفا داده های ورودی را به صورت صحیح وارد نمایید", DataModel.Enum.ErrorType.Warning);
            }

            if (string.IsNullOrEmpty(inputModel.PhoneNo))
            {
                return new BaseResult_VM(null, -1, "لطفا شماره همراه کاربر را به صورت صحیح وارد نمایید", DataModel.Enum.ErrorType.Warning);
            }

            bool isUniqueCode = true;
            while(isUniqueCode)
            {
                var activeCode = GenerateActicationCode();
                if (activeCode == null)
                {
                    return new BaseResult_VM(null, -1, "خطا در درج کد اعتبارسنجی", DataModel.Enum.ErrorType.Error);
                }
                var existCode = GetActivationCode(new Activation_VM { ActivationCode = (int)activeCode.Result });
                if (existCode.Result != null)
                {
                    activeCode = GenerateActicationCode();
                    continue;
                }
                isUniqueCode = false;
                inputModel.ActivationCode = Convert.ToInt32(activeCode.Result);
            }
            
            int Id = dlActivation.InsertActivation(inputModel);



            return new BaseResult_VM(inputModel.ActivationCode, 0, "عملیات با موفقیت انجام شد", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
