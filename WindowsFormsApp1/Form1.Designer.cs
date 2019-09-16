namespace WindowsFormsApp1 {
  partial class Form1 {
    /// <summary>
    /// 必要なデザイナー変数です。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 使用中のリソースをすべてクリーンアップします。
    /// </summary>
    /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows フォーム デザイナーで生成されたコード

    /// <summary>
    /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
    /// コード エディターで変更しないでください。
    /// </summary>
    private void InitializeComponent() {
      this.button1 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.rdoTest = new System.Windows.Forms.RadioButton();
      this.rdoRelease = new System.Windows.Forms.RadioButton();
      this.button2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(55, 69);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.Button1_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(153, 71);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(340, 19);
      this.textBox1.TabIndex = 1;
      this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
      // 
      // rdoTest
      // 
      this.rdoTest.AutoSize = true;
      this.rdoTest.Location = new System.Drawing.Point(195, 24);
      this.rdoTest.Name = "rdoTest";
      this.rdoTest.Size = new System.Drawing.Size(73, 16);
      this.rdoTest.TabIndex = 2;
      this.rdoTest.TabStop = true;
      this.rdoTest.Text = "テスト環境";
      this.rdoTest.UseVisualStyleBackColor = true;
      // 
      // rdoRelease
      // 
      this.rdoRelease.AutoSize = true;
      this.rdoRelease.Location = new System.Drawing.Point(274, 24);
      this.rdoRelease.Name = "rdoRelease";
      this.rdoRelease.Size = new System.Drawing.Size(71, 16);
      this.rdoRelease.TabIndex = 3;
      this.rdoRelease.TabStop = true;
      this.rdoRelease.Text = "本番環境";
      this.rdoRelease.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(55, 121);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 4;
      this.button2.Text = "button2";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.Button2_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(550, 181);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.rdoRelease);
      this.Controls.Add(this.rdoTest);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.RadioButton rdoTest;
    private System.Windows.Forms.RadioButton rdoRelease;
    private System.Windows.Forms.Button button2;
  }
}

