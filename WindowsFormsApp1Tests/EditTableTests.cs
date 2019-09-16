using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace WindowsFormsApp1.Tests {
  [TestClass()]
  public class EditTableTests {
    [TestMethod()]
    public void EditTest() {
      var entityitem = new T_PassWord(){
        CompanyCode = 2,
        EmployeeCode = "200026",
        OldID = "kimuraBBB"
      };

      var edit = new EditTable<T_PassWord, MusuHR_TEntities>();
      edit.Edit(entityitem);

      using (var entity2 = new MusuHR_TEntities()) {
        var founditem = entity2.T_PassWord.FirstOrDefault(find => find.EmployeeCode == entityitem.EmployeeCode);
        Assert.AreEqual(founditem.OldID, entityitem.OldID);
      }
    }

    [TestMethod()]
    public void EditTest2() {
      var entityitem = new T_PassWord() {
        CompanyCode = 2,
        EmployeeCode = "200099",
        OldID = "ZZZ"
      };

      using (var entity2 = new MusuHR_TEntities()) {
        var founditem = entity2.T_PassWord.FirstOrDefault(find => find.EmployeeCode == entityitem.EmployeeCode);
        if(founditem != null) {
          entity2.T_PassWord.Remove(founditem);
          entity2.SaveChanges();
        }
      }

      var edit = new EditTable<T_PassWord, MusuHR_TEntities>();
      edit.Edit(entityitem);

      using (var entity2 = new MusuHR_TEntities()) {
        var founditem = entity2.T_PassWord.FirstOrDefault(find => find.EmployeeCode == entityitem.EmployeeCode);
        Assert.AreEqual(founditem.OldID, entityitem.OldID);
      }
    }
  }
}