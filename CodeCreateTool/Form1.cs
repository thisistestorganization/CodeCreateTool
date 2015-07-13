using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.IO;

namespace CodeCreateTool
{
    public partial class Form1 : Form
    {
        string db = "chefafadb_erp";
        public Form1()
        {
            InitializeComponent();
            //strConn = " select  column_name  from Information_schema.columns where table_schema='chefafadb_erp' and table_Name='cff_users' ";
            //select table_Name from Information_schema.tables where table_schema='chefafadb_erp' 
            txtconnStr.Text = DBHelper.connStr;
            DataTable dt = DBHelper.ExecuteDataTable("select table_Name from Information_schema.tables where table_schema='"+db+"'");
            this.txtConsoleOutput.Text = "数据库连接成功...";
            foreach (DataRow item in dt.Rows)
            {
                lvtableList.Items.Add(item[0].ToString());
            }
            this.txtConsoleOutput.Text = this.txtConsoleOutput.Text + "\r\n数据库表单加载...";
            lvtableList.Show();
        }

        private void btnlinkDB_Click(object sender, EventArgs e)
        {
            lvtableList.Clear();
            if (!string.IsNullOrWhiteSpace(txtconnStr.Text))
            {
                string connStr=txtconnStr.Text;
                db = connStr.Substring(connStr.LastIndexOf("=")+1, connStr.Length-1 - connStr.LastIndexOf("="));
                DBHelper.connStr =connStr ;
                DataTable dt = DBHelper.ExecuteDataTable("select table_Name from Information_schema.tables where table_schema='"+db+"'");
                this.txtConsoleOutput.Text = "数据库连接成功...";
                foreach (DataRow item in dt.Rows)
                {
                    lvtableList.Items.Add(item[0].ToString());
                }
                this.txtConsoleOutput.Text = this.txtConsoleOutput.Text + "\r\n数据库表单加载...";
                lvtableList.Show();
            }
            else
            {
                MessageBox.Show("请输入连接字符串");
                this.txtConsoleOutput.Text = this.txtConsoleOutput.Text + "\r\n错误...";
            }
            
            
        }
        

        private void btnCreateCode_Click(object sender, EventArgs e)
        {
            int i = lvtableList.CheckedItems.Count;
            string[] para = new string[i];
            i = 0;
            DataSet ds = new DataSet();
            DataTable dt=null;
            foreach (ListViewItem item in lvtableList.CheckedItems)
            {
                string tableName=item.Text;
                this.txtConsoleOutput.Text = this.txtConsoleOutput.Text + "\r\n开始加载数据...";
                dt = DBHelper.ExecuteDataTable("select  column_name,data_type  from Information_schema.columns where table_schema='"+db+"' and table_Name='" + tableName + "'");
                dt.TableName = tableName;
                ds.Tables.Add(dt);
                i++;
            }
            this.txtConsoleOutput.Text = this.txtConsoleOutput.Text + "\r\n开始生成文本...";
            CreateCodeLogic(ds);

        }

        public bool CreateCodeLogic(DataSet ds) 
        {
            
            bool isOk = false;
            string Gen_Path = this.txtGenPath.Text;
            if (!string.IsNullOrWhiteSpace(Gen_Path))
            {
                
                if (ds.Tables.Count <= 0)
                {
                    return false;
                }
                else
                {
                    foreach (DataTable table in ds.Tables)
                    {
                        this.txtConsoleOutput.Text = this.txtConsoleOutput.Text + "\r\n开始生成" + table.TableName + "...";
                        int i=0;
                        Directory.CreateDirectory(Gen_Path);
                        StringBuilder sb= new StringBuilder("");
                        sb.AppendLine("using System;");
                        sb.AppendLine("using System.Collections.Generic;");
                        sb.AppendLine("using System.Linq;");
                        sb.AppendLine("using System.Text;");
                        sb.AppendLine("using System.Threading.Tasks;");
                        sb.AppendLine();
                        sb.AppendLine("namespace CodeCreateTool");
                        
                        sb.AppendLine("{");
                        sb.AppendLine("\r\tpublic class " + table.TableName + "");
                        sb.AppendLine("\r\t{");
                        foreach (DataRow Row in table.Rows)
                        {
                            i++;
                            this.txtConsoleOutput.Text = this.txtConsoleOutput.Text + "\r\n生成" + i+"/"+table.Rows.Count+ "...";
                            //string property = Row.ItemArray[0].ToString();
                           MySqlDataType type =(MySqlDataType)Enum.Parse(typeof(MySqlDataType), Row.ItemArray[1].ToString().ToUpper());
                            
                            switch (type)
                            {
                                    
                                case MySqlDataType.DECIMAL:
                                case MySqlDataType.DOUBLE:
                                case MySqlDataType.NEWDECIMAL:
                                    sb.AppendLine("\r\t\r\tpublic double " + Row.ItemArray[0].ToString() + "{get;set;}");
                                    break;
                                case MySqlDataType.MEDIUMINT:
                                case MySqlDataType.INT16:
                                case MySqlDataType.INT32:
                                case MySqlDataType.INT:
                                case MySqlDataType.SMALLINT:
                                    sb.AppendLine("\r\t\r\tpublic int " + Row.ItemArray[0].ToString() + "{get;set;}");
                                    break;
                                case MySqlDataType.TEXT:
                                case MySqlDataType.CHAR:
                                case MySqlDataType.VARCHAR:
                                case MySqlDataType.STRING:
                                    sb.AppendLine("\r\t\r\tpublic string " + Row.ItemArray[0].ToString() + "{get;set;}");
                                    break;
                                default:
                                    break;
                            }
                        }
                        sb.AppendLine("\r\t}");
                        sb.AppendLine("}");
                        File.WriteAllText(Gen_Path +"\\"+ table.TableName + ".txt", sb.ToString());
                        this.txtConsoleOutput.Text = this.txtConsoleOutput.Text + "生成成功...";
                    }
                }
            }
            else
            {
                MessageBox.Show("选择生成路径");
                isOk = false;
            }

            return isOk;
        }

        

        private void btnGenPath_Click(object sender, EventArgs e)
        {
            //this.fbdGenPath.ShowDialog();
            this.fbdGenPath.Description = "请选择路径";
            if (this.fbdGenPath.ShowDialog() == DialogResult.OK)
            {
                txtGenPath.Text = this.fbdGenPath.SelectedPath;
            }
        }

    }

    public class DBHelper 
    {
        public static string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        
        public static DataTable ExecuteDataTable(string sql) 
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand(sql);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql,conn);
            da.Fill(dt);
            return dt;
        }
    }
   
}
