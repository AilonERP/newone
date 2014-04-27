using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HrDBAPP;
using HrModel;

namespace HrBssAPP
{
  public   class DictionaryBLL
  {
      DictionaryDAL getedu = new DictionaryDAL();
      //DicNameDAL getdicname = new DicNameDAL();

      public List<Dictionary_info> GetEdu() 
      {

        List<Dictionary_info> list=  getedu.GetEdu();
        return list;
      
      }

      public List<Dictionary_info> GetDicName() 
      {

          List<Dictionary_info> list1 = getedu.GetDicName();
          return list1;
      
      }

      public List<Dictionary_info> GetPost()
      {

          List<Dictionary_info> list2 = getedu.GetPost();
          return list2;

      } 

    }
}
