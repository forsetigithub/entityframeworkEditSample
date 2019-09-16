using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp1 {
  public partial class Form1 : Form {

    private readonly NLog.ILogger logger;
    public Form1(NLog.ILogger logger) {
      InitializeComponent();
      this.logger = logger;
    }

    private void Form1_Load(object sender, EventArgs e) {

    }

    private void TextBox1_TextChanged(object sender, EventArgs e) {

    }

    private void Button1_Click(object sender, EventArgs e) {
      using(var con = new SqlConnection()) {
        var settings =  ConfigurationManager.ConnectionStrings["MusuHR_TEntities"];

        if (settings == null) {
          MessageBox.Show("App.config未登録");
        } else {
          var constrings = settings.ConnectionString.Split(';');
          foreach (var constring in constrings) {
            Console.WriteLine(constring);
            logger.Info(constring);
            logger.Debug(constring);
          }
        }
      }

    }

    private void Button2_Click(object sender, EventArgs e) {
      try {
        var entityitem = new T_PassWord() {
          CompanyCode = 2,
          EmployeeCode = "200026",
          OldID = "kimuraZccccd"
        };

        var edit = new EditTable<T_PassWord,MusuHR_TEntities>();
        edit.Edit(entityitem);

      } catch (Exception ex) {
        MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
      }
    }
  }
}
