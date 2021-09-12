using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicajueves9092021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetName_Click(object sender, EventArgs e)
        {
            //llamado al metodo selectName
            selectName();
        }

        //metodo para obtener los nombres de la coleccion 
        private void selectName()
        {
            //consulta 
            List<string> query = (
                from student in Student.GetStudents()
                select student.fistName
                ).ToList();

            //recorrer lista y llenar lstNames 
            foreach (var name in query)
            {
                //llenar lstNames 
                lstNames.Items.Add(name);
            }
        }

        private void btnGetData_Click_1(object sender, EventArgs e)
        {
            //agregar columnas al DataGridview
            dgData.Columns.Add("idStudent", "CODIGO");
            dgData.Columns.Add("firstname", "NOMBRE");
            dgData.Columns.Add("lastname", "APELLIDO");
            dgData.Columns.Add("age", "EDAD");
            dgData.Columns.Add("Nacionalidad", "Nacionalidad");

            foreach(var student in selectAllData())
            {
                dgData.Rows.Add(student.idStudent, student.fistName, student.lastName,
                    student.age,student.Nacionalidad);
            }
        }

        //metodo para consultar todos los datos de la coleccion
        private List<Student> selectAllData()
        {
            List<Student> query = (
                from student in Student.GetStudents()
                select new Student()
                  {
                    idStudent =student.idStudent,
                    fistName = student.fistName,
                    lastName = student.lastName,
                    age = student.age,
                    Nacionalidad =student.Nacionalidad
                  }
                ).ToList();
            return query;
        }
    }
}
