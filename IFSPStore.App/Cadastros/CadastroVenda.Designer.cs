namespace IFSPStore.App.Cadastros
{
    partial class CadastroVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDataVenda = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboUsuario = new ReaLTaiizor.Controls.MaterialComboBox();
            cboCliente = new ReaLTaiizor.Controls.MaterialComboBox();
            groupBox1 = new GroupBox();
            cboProduto = new ReaLTaiizor.Controls.MaterialComboBox();
            txtVIUnitario = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtQuantidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtVITotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnAdicionar = new ReaLTaiizor.Controls.MaterialButton();
            IbIQtdItens = new ReaLTaiizor.Controls.MaterialLabel();
            IbIValor = new ReaLTaiizor.Controls.MaterialLabel();
            dataGridViewItens = new DataGridView();
            tabPage1.SuspendLayout();
            tabControlCadastro.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItens).BeginInit();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(cboCliente);
            tabPage1.Controls.Add(cboUsuario);
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(txtDataVenda);
            tabPage1.Controls.SetChildIndex(txtDataVenda, 0);
            tabPage1.Controls.SetChildIndex(txtId, 0);
            tabPage1.Controls.SetChildIndex(cboUsuario, 0);
            tabPage1.Controls.SetChildIndex(cboCliente, 0);
            tabPage1.Controls.SetChildIndex(groupBox1, 0);
            // 
            // txtDataVenda
            // 
            txtDataVenda.AllowPromptAsInput = true;
            txtDataVenda.AnimateReadOnly = false;
            txtDataVenda.AsciiOnly = false;
            txtDataVenda.BackgroundImageLayout = ImageLayout.None;
            txtDataVenda.BeepOnError = false;
            txtDataVenda.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataVenda.Depth = 0;
            txtDataVenda.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataVenda.HidePromptOnLeave = false;
            txtDataVenda.HideSelection = true;
            txtDataVenda.Hint = "Data da Venda";
            txtDataVenda.InsertKeyMode = InsertKeyMode.Default;
            txtDataVenda.LeadingIcon = null;
            txtDataVenda.Location = new Point(6, 6);
            txtDataVenda.Mask = "99/99/9999";
            txtDataVenda.MaxLength = 32767;
            txtDataVenda.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataVenda.Name = "txtDataVenda";
            txtDataVenda.PasswordChar = '\0';
            txtDataVenda.PrefixSuffixText = null;
            txtDataVenda.PromptChar = '_';
            txtDataVenda.ReadOnly = false;
            txtDataVenda.RejectInputOnFirstFailure = false;
            txtDataVenda.ResetOnPrompt = true;
            txtDataVenda.ResetOnSpace = true;
            txtDataVenda.RightToLeft = RightToLeft.No;
            txtDataVenda.SelectedText = "";
            txtDataVenda.SelectionLength = 0;
            txtDataVenda.SelectionStart = 0;
            txtDataVenda.ShortcutsEnabled = true;
            txtDataVenda.Size = new Size(250, 48);
            txtDataVenda.SkipLiterals = true;
            txtDataVenda.TabIndex = 2;
            txtDataVenda.TabStop = false;
            txtDataVenda.Text = "  /  /";
            txtDataVenda.TextAlign = HorizontalAlignment.Left;
            txtDataVenda.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataVenda.TrailingIcon = null;
            txtDataVenda.UseSystemPasswordChar = false;
            txtDataVenda.ValidatingType = null;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(699, 6);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(63, 48);
            txtId.TabIndex = 3;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // cboUsuario
            // 
            cboUsuario.AutoResize = false;
            cboUsuario.BackColor = Color.FromArgb(255, 255, 255);
            cboUsuario.Depth = 0;
            cboUsuario.DrawMode = DrawMode.OwnerDrawVariable;
            cboUsuario.DropDownHeight = 174;
            cboUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUsuario.DropDownWidth = 121;
            cboUsuario.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboUsuario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboUsuario.FormattingEnabled = true;
            cboUsuario.Hint = "Usuário/Vendedor";
            cboUsuario.IntegralHeight = false;
            cboUsuario.ItemHeight = 43;
            cboUsuario.Location = new Point(262, 6);
            cboUsuario.MaxDropDownItems = 4;
            cboUsuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboUsuario.Name = "cboUsuario";
            cboUsuario.Size = new Size(431, 49);
            cboUsuario.StartIndex = 0;
            cboUsuario.TabIndex = 4;
            // 
            // cboCliente
            // 
            cboCliente.AutoResize = false;
            cboCliente.BackColor = Color.FromArgb(255, 255, 255);
            cboCliente.Depth = 0;
            cboCliente.DrawMode = DrawMode.OwnerDrawVariable;
            cboCliente.DropDownHeight = 174;
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.DropDownWidth = 121;
            cboCliente.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCliente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCliente.FormattingEnabled = true;
            cboCliente.Hint = "Cliente";
            cboCliente.IntegralHeight = false;
            cboCliente.ItemHeight = 43;
            cboCliente.Location = new Point(6, 61);
            cboCliente.MaxDropDownItems = 4;
            cboCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(756, 49);
            cboCliente.StartIndex = 0;
            cboCliente.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewItens);
            groupBox1.Controls.Add(IbIValor);
            groupBox1.Controls.Add(IbIQtdItens);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(txtVITotal);
            groupBox1.Controls.Add(txtQuantidade);
            groupBox1.Controls.Add(txtVIUnitario);
            groupBox1.Controls.Add(cboProduto);
            groupBox1.Location = new Point(6, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(756, 185);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produtos da Venda";
            // 
            // cboProduto
            // 
            cboProduto.AutoResize = false;
            cboProduto.BackColor = Color.FromArgb(255, 255, 255);
            cboProduto.Depth = 0;
            cboProduto.DrawMode = DrawMode.OwnerDrawVariable;
            cboProduto.DropDownHeight = 174;
            cboProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProduto.DropDownWidth = 121;
            cboProduto.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboProduto.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboProduto.FormattingEnabled = true;
            cboProduto.Hint = "Produto";
            cboProduto.IntegralHeight = false;
            cboProduto.ItemHeight = 43;
            cboProduto.Location = new Point(6, 22);
            cboProduto.MaxDropDownItems = 4;
            cboProduto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboProduto.Name = "cboProduto";
            cboProduto.Size = new Size(264, 49);
            cboProduto.StartIndex = 0;
            cboProduto.TabIndex = 0;
            // 
            // txtVIUnitario
            // 
            txtVIUnitario.AnimateReadOnly = false;
            txtVIUnitario.AutoCompleteMode = AutoCompleteMode.None;
            txtVIUnitario.AutoCompleteSource = AutoCompleteSource.None;
            txtVIUnitario.BackgroundImageLayout = ImageLayout.None;
            txtVIUnitario.CharacterCasing = CharacterCasing.Normal;
            txtVIUnitario.Depth = 0;
            txtVIUnitario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtVIUnitario.HideSelection = true;
            txtVIUnitario.Hint = "VI.Unit.";
            txtVIUnitario.LeadingIcon = null;
            txtVIUnitario.Location = new Point(276, 22);
            txtVIUnitario.MaxLength = 32767;
            txtVIUnitario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtVIUnitario.Name = "txtVIUnitario";
            txtVIUnitario.PasswordChar = '\0';
            txtVIUnitario.PrefixSuffixText = null;
            txtVIUnitario.ReadOnly = false;
            txtVIUnitario.RightToLeft = RightToLeft.No;
            txtVIUnitario.SelectedText = "";
            txtVIUnitario.SelectionLength = 0;
            txtVIUnitario.SelectionStart = 0;
            txtVIUnitario.ShortcutsEnabled = true;
            txtVIUnitario.Size = new Size(141, 48);
            txtVIUnitario.TabIndex = 1;
            txtVIUnitario.TabStop = false;
            txtVIUnitario.TextAlign = HorizontalAlignment.Left;
            txtVIUnitario.TrailingIcon = null;
            txtVIUnitario.UseSystemPasswordChar = false;
            // 
            // txtQuantidade
            // 
            txtQuantidade.AnimateReadOnly = false;
            txtQuantidade.AutoCompleteMode = AutoCompleteMode.None;
            txtQuantidade.AutoCompleteSource = AutoCompleteSource.None;
            txtQuantidade.BackgroundImageLayout = ImageLayout.None;
            txtQuantidade.CharacterCasing = CharacterCasing.Normal;
            txtQuantidade.Depth = 0;
            txtQuantidade.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantidade.HideSelection = true;
            txtQuantidade.Hint = "Qtd";
            txtQuantidade.LeadingIcon = null;
            txtQuantidade.Location = new Point(423, 22);
            txtQuantidade.MaxLength = 32767;
            txtQuantidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PasswordChar = '\0';
            txtQuantidade.PrefixSuffixText = null;
            txtQuantidade.ReadOnly = false;
            txtQuantidade.RightToLeft = RightToLeft.No;
            txtQuantidade.SelectedText = "";
            txtQuantidade.SelectionLength = 0;
            txtQuantidade.SelectionStart = 0;
            txtQuantidade.ShortcutsEnabled = true;
            txtQuantidade.Size = new Size(115, 48);
            txtQuantidade.TabIndex = 2;
            txtQuantidade.TabStop = false;
            txtQuantidade.TextAlign = HorizontalAlignment.Left;
            txtQuantidade.TrailingIcon = null;
            txtQuantidade.UseSystemPasswordChar = false;
            // 
            // txtVITotal
            // 
            txtVITotal.AnimateReadOnly = false;
            txtVITotal.AutoCompleteMode = AutoCompleteMode.None;
            txtVITotal.AutoCompleteSource = AutoCompleteSource.None;
            txtVITotal.BackgroundImageLayout = ImageLayout.None;
            txtVITotal.CharacterCasing = CharacterCasing.Normal;
            txtVITotal.Depth = 0;
            txtVITotal.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtVITotal.HideSelection = true;
            txtVITotal.Hint = "VI.Total";
            txtVITotal.LeadingIcon = null;
            txtVITotal.Location = new Point(558, 22);
            txtVITotal.MaxLength = 32767;
            txtVITotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtVITotal.Name = "txtVITotal";
            txtVITotal.PasswordChar = '\0';
            txtVITotal.PrefixSuffixText = null;
            txtVITotal.ReadOnly = false;
            txtVITotal.RightToLeft = RightToLeft.No;
            txtVITotal.SelectedText = "";
            txtVITotal.SelectionLength = 0;
            txtVITotal.SelectionStart = 0;
            txtVITotal.ShortcutsEnabled = true;
            txtVITotal.Size = new Size(109, 48);
            txtVITotal.TabIndex = 3;
            txtVITotal.TabStop = false;
            txtVITotal.TextAlign = HorizontalAlignment.Left;
            txtVITotal.TrailingIcon = null;
            txtVITotal.UseSystemPasswordChar = false;
            // 
            // btnAdicionar
            // 
            btnAdicionar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdicionar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdicionar.Depth = 0;
            btnAdicionar.HighEmphasis = true;
            btnAdicionar.Icon = null;
            btnAdicionar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAdicionar.Location = new Point(685, 25);
            btnAdicionar.Margin = new Padding(4, 6, 4, 6);
            btnAdicionar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.NoAccentTextColor = Color.Empty;
            btnAdicionar.Size = new Size(64, 36);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "+";
            btnAdicionar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdicionar.UseAccentColor = false;
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // IbIQtdItens
            // 
            IbIQtdItens.AutoSize = true;
            IbIQtdItens.Depth = 0;
            IbIQtdItens.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            IbIQtdItens.Location = new Point(6, 163);
            IbIQtdItens.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            IbIQtdItens.Name = "IbIQtdItens";
            IbIQtdItens.Size = new Size(115, 19);
            IbIQtdItens.TabIndex = 5;
            IbIQtdItens.Text = "Qtd. Produtos: 0";
            // 
            // IbIValor
            // 
            IbIValor.AutoSize = true;
            IbIValor.Depth = 0;
            IbIValor.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            IbIValor.Location = new Point(618, 163);
            IbIValor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            IbIValor.Name = "IbIValor";
            IbIValor.Size = new Size(96, 19);
            IbIValor.TabIndex = 6;
            IbIValor.Text = "Valor Total: 0";
            // 
            // dataGridViewItens
            // 
            dataGridViewItens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItens.Location = new Point(6, 76);
            dataGridViewItens.Name = "dataGridViewItens";
            dataGridViewItens.Size = new Size(744, 74);
            dataGridViewItens.TabIndex = 7;
            // 
            // CadastroVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroVenda";
            Text = "CadastroVenda";
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControlCadastro.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItens).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboCliente;
        private ReaLTaiizor.Controls.MaterialComboBox cboUsuario;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataVenda;
        private GroupBox groupBox1;
        private DataGridView dataGridViewItens;
        private ReaLTaiizor.Controls.MaterialLabel IbIValor;
        private ReaLTaiizor.Controls.MaterialLabel IbIQtdItens;
        private ReaLTaiizor.Controls.MaterialButton btnAdicionar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtVITotal;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQuantidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtVIUnitario;
        private ReaLTaiizor.Controls.MaterialComboBox cboProduto;
    }
}