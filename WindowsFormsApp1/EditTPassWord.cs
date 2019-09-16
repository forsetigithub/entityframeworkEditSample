using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1 {
  public class EditTPassWord {
    private IEditEntity<T_PassWord> editEntity;
    public EditTPassWord(IEditEntity<T_PassWord> editEntity) {
      this.editEntity = editEntity;
    }

    public void Edit(T_PassWord entity) {
      this.editEntity.Edit(entity);
    }
  }
}
