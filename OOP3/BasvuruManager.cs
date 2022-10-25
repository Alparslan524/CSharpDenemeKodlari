using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(ICrediManager crediManager)//Log işlemi olmayan BasvuruYap
        {
            crediManager.Calculate();
        }

        public void BasvuruYap(ICrediManager crediManager,ILog log)//Log işlemi olan BasvuruYap
       {//Eğer bu şekilde interface parametresi göndermeseydik yeni bir kredi ekleyeceğimizde mavcut kodu bozmamız gerekiyordu
            //Ve; ya kod tekrarı yapacaktık ya da onlarca if-else-method yazacaktık
            crediManager.Calculate();
            log.Logging();
        }//Method override
    
        public void CrediInfo(List<ICrediManager> credies)
        {
            foreach (var credi in credies)
            {
                credi.Calculate();
            }
        }
    }
}
