using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJETOMVCA27.DALMVC;
using PROJETOMVCA27.BLLMVC;
using PROJETOMVCA27.DTOMVC;

namespace PROJETOMVCA27
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void txt_cpfa27_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            try
            {
                DTOMVCA41 objDTO = new DTOMVCA41();
                BLLMVCA41 objBLL = new BLLMVCA41();

                objDTO.Cpf_cliente = txt_cpfa27.Text.Trim();
                objDTO.Nome_cliente = txt_nomea27.Text.Trim();
                objDTO.Nome_mae = txt_nomemaea27.Text.Trim();

                if (objBLL.Autenticar(objDTO.Cpf_cliente, objDTO.Nome_cliente, objDTO.Nome_mae))
                {
                    MessageBox.Show("Beneficiário localizado no banco de dados. Processo em análise!");
                }
                else
                {
                    MessageBox.Show("Beneficiário não Localizado no banco de dados. Benefício Negado!");
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Erro: \n" + fe.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception fe)
            {
                MessageBox.Show(fe.Message);
            }
        }
    }
}
