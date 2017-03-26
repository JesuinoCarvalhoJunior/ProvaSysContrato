using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Prova.SysContrato.View
{
    public static class HelperOpenScreen
    {

        //    private Dictionary<Type, Form> dicForms = new Dictionary<Type, Form>();

        private static Dictionary<Type, Form> Instancias = new Dictionary<Type, Form>();

        /*
             public void CarregaTela<T>()
             {
                 CarregarTela(typeof(T));
             }


                     public void CarregarTela(Type type)
                     {
                         bool carregar = true;
                         Form f = null;
                         try
                         {
                             if (dicForms.ContainsKey(type))
                             {
                                 if (dicForms.TryGetValue(type, out f))
                                 {
                                     if (!f.IsDisposed)
                                     {
                                         f.Focus();
                                         carregar = false;
                                     }
                                     else
                                     {
                                         dicForms.Remove(type);
                                     }
                                 }
                             }

                             if (carregar)
                             {
                                 Cursor.Current = Cursors.WaitCursor;

                                 f = (Form)Activator.CreateInstance(type);
                                 dicForms.Add(type, f);
                                 //f.MdiParent = this;
                                 f.FormBorderStyle = FormBorderStyle.FixedSingle;
                                 f.StartPosition = FormStartPosition.CenterScreen;
                                 f.MaximizeBox = false;
                                 f.Show();
                             }
                         }
                         catch (Exception ex)
                         {
                             dicForms.Remove(type);
                             MessageBox.Show("Não foi possível inicializar a tela " + type.Name + "!" + "\n\nCausa:" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                             if (f != null)

                             {
                                 f.Close();
                                 f.Dispose();
                             }
                         }
                         finally
                         {
                             Cursor.Current = Cursors.Default;
                         }
                     }
                 }
                 */
        public static void AbrirFormulario<T>() where T : Form
        {
            Form formulario = null;
            Type tipoFormulario = typeof(T);

            try
            {

                if (Instancias.ContainsKey(tipoFormulario))
                {
                    if (Instancias.TryGetValue(tipoFormulario, out formulario))
                    {
                        if (!formulario.IsDisposed)
                        {
                            formulario.Focus();
                        }
                        else
                        {
                            Instancias.Remove(tipoFormulario);
                        }
                    }
                }

                if (!Instancias.ContainsKey(tipoFormulario))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    formulario = Activator.CreateInstance<T>();
                    Instancias.Add(tipoFormulario, formulario);

                    formulario.MdiParent = FMenu.ActiveForm; //this;
                    formulario.FormBorderStyle = FormBorderStyle.FixedSingle;
                    formulario.StartPosition = FormStartPosition.CenterScreen;
                    formulario.MaximizeBox = false;

                    formulario.Show();
                }
                else
                {
                    formulario = Instancias[tipoFormulario];
                }

                formulario.BringToFront();
            }
            catch (Exception ex)
            {
                Instancias.Remove(tipoFormulario);
                MessageBox.Show("Não foi possível inicializar a tela " +
                                 tipoFormulario.Name + "!" + "\n\nCausa:" +
                                 ex.Message, "Aviso", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                if (formulario != null)
                {
                    formulario.Close();
                    formulario.Dispose();
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}