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
       {
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
