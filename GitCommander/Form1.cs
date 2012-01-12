using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;

namespace GitCommander
{
    public partial class Form1 : Form
    {
        Settings settings;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            settings = Settings.Load(Application.StartupPath + "\\settings.txt");
            gitpath.Text = settings.git_path;
            workingdir.Text = settings.working_dir;
           richTextBox1.Text = settings.text1;
           richTextBox2.Text = settings.text2;
           richTextBox3.Text = settings.text3;
           richTextBox4.Text = settings.text4;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            settings.Save("settings.txt");
        }

        private void gitpath_TextChanged(object sender, EventArgs e)
        {
            settings.git_path = gitpath.Text;
        }

        private void workingdir_TextChanged(object sender, EventArgs e)
        {
            settings.working_dir = workingdir.Text;
        }

        private void Exec(string git_command)
        {
            List<string> coms = git_command.Split('\n').ToList<string>();
            for (int i = 0; i < coms.Count; i++)
            {
                if (coms[i] == "commit") { commit(); coms[i] = "status"; }
                coms[i] = "\"" + settings.git_path + "\\bin\\git\" " + coms[i] + "\"\"";    }
            Exec(coms);
        }


        private void Exec(List<string> git_commands)
        {
            try
            {
                List<string> commands = new List<string>();
                commands.Add(settings.working_dir.Substring(0, 2));
                commands.Add("cd " + settings.working_dir);

                foreach(string gc in git_commands)  
                    commands.Add(gc);

                string parameters = "/k ";

                if (commands.Count > 1)
                {
                    parameters += "\"";
                    foreach (string command in commands)
                    {
                        parameters += command + "&&";
                    }
                    parameters = parameters.Substring(0, parameters.Length - 2);
                    parameters += "\"";
                }
                else if (commands.Count == 1)
                    parameters += commands[0];
                else return;

                Process.Start("cmd.exe", parameters);
            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void commit()
        {
            if (commitname.Text.Length < 3) MessageBox.Show("Enter CommitName please!!");
            else
            {
                Exec("commit -a -m \"" + commitname.Text + "\"");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Exec("pull");
            commit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Exec(richTextBox1.Text);
        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            settings.text1 = richTextBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exec(richTextBox2.Text);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Exec(richTextBox4.Text);
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            settings.text3 = richTextBox3.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exec(richTextBox3.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Exec(textBox1.Text);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            settings.text2 = richTextBox2.Text;
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            settings.text4 = richTextBox4.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            settings.Save("settings.txt");
        }


    }

    [Serializable]
    public class Settings
    {
        public string git_path = @"C:\Program Files (x86)\Git";
        public string working_dir = "";
        public string text1 = "";
        public string text2 = "";
        public string text3 = "";
        public string text4 = "";
        public void Save(string file)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                StreamWriter sw = new StreamWriter(file);
                serializer.Serialize(sw, this);
                sw.Close();
            }
            catch (Exception ee)            {         MessageBox.Show(ee.Message);         }
        }

        public static Settings Load(string file)
        {
            try
            {
                StreamReader sr = new StreamReader(file);
                XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                Settings result = (Settings)serializer.Deserialize(sr);
                sr.Close();
                return result;
            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }
            return new Settings();
        }

    }

   
}
