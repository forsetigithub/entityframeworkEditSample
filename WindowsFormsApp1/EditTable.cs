using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace WindowsFormsApp1 {
  public enum STATE_FLG {
    INSERT,
    UPDATE
  }

  public class EditTable<T1,T2> : IEditEntity<T1> where T1: class where T2: DbContext, new() {
    public bool Edit(T1 entityitem) {

      bool result = false;
      STATE_FLG stateFlag = STATE_FLG.UPDATE;

      if (entityitem == null) {
        throw new Exception("entity is null error!");
      }

      using (var entity = new T2()) {
        try {
         
          //主キーの列名を取得
          var objectContext = ((System.Data.Entity.Infrastructure.IObjectContextAdapter)entity).ObjectContext;
          var objectSet = objectContext.CreateObjectSet<T1>();
          
          var keyNames = objectSet.EntitySet.ElementType.KeyMembers.Select(k => k.Name).ToArray();
          
          //主キーの値を取得する
          objectSet.Attach(entityitem);

          var currentValues = entity.Entry(entityitem).CurrentValues;
          
          List<object> foundkeys = new List<object>();

          foreach (var keyname in keyNames) {
            var foundvalue = currentValues.GetValue<object>(keyname);

            foundkeys.Add(foundvalue);
          }

          //一旦コンテキストから削除
          objectSet.Detach(entityitem);

          var founditem = entity.Set<T1>().Find(foundkeys.ToArray());

          if (founditem == null) {
            stateFlag = STATE_FLG.INSERT;
          } else {
            entity.Entry(founditem).State = EntityState.Detached;
          }

          entity.Entry(entityitem).State = stateFlag == STATE_FLG.INSERT ? EntityState.Added : 
            EntityState.Modified;

          entity.SaveChanges();

          result = true;

        } catch (System.Data.SqlClient.SqlException sqlex) {
          throw;
        } catch (Exception ex) {
          throw;
        }
      }

      return result;
    }

  }
}
