
namespace RentalMoviesProject
{
    partial class Form1
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
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.btnInsertCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnShowCustomer = new System.Windows.Forms.Button();
            this.btnShowMovies = new System.Windows.Forms.Button();
            this.btnShowRentedMovies = new System.Windows.Forms.Button();
            this.btnInsertMovie = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnFamousMovie = new System.Windows.Forms.Button();
            this.btnFamousCustomer = new System.Windows.Forms.Button();
            this.btnIssueMovie = new System.Windows.Forms.Button();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.FirstNLabel = new System.Windows.Forms.Label();
            this.LastNLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.MovieIDLabel = new System.Windows.Forms.Label();
            this.CustomerIDtxtbox = new System.Windows.Forms.TextBox();
            this.FirstNtxtbox = new System.Windows.Forms.TextBox();
            this.LastNtxtbox = new System.Windows.Forms.TextBox();
            this.Addresstxtbox = new System.Windows.Forms.TextBox();
            this.Phonetxtbox = new System.Windows.Forms.TextBox();
            this.Movietxtbox = new System.Windows.Forms.TextBox();
            this.Ranklbl = new System.Windows.Forms.Label();
            this.Headlinelbl = new System.Windows.Forms.Label();
            this.Yearlbl = new System.Windows.Forms.Label();
            this.RentalChargelbl = new System.Windows.Forms.Label();
            this.Copieslbl = new System.Windows.Forms.Label();
            this.Plotlbl = new System.Windows.Forms.Label();
            this.Categorylbl = new System.Windows.Forms.Label();
            this.Ranktxtbox = new System.Windows.Forms.TextBox();
            this.Headlinetxtbox = new System.Windows.Forms.TextBox();
            this.RentalChargetxtbox = new System.Windows.Forms.TextBox();
            this.Copiestxtbox = new System.Windows.Forms.TextBox();
            this.Plottxtbox = new System.Windows.Forms.TextBox();
            this.Categorytextbox = new System.Windows.Forms.TextBox();
            this.Yeartxtbox = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.Aqua;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(24, 92);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 62;
            this.dgvCustomer.RowTemplate.Height = 28;
            this.dgvCustomer.Size = new System.Drawing.Size(1160, 431);
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            // 
            // btnInsertCustomer
            // 
            this.btnInsertCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInsertCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertCustomer.Location = new System.Drawing.Point(24, 548);
            this.btnInsertCustomer.Name = "btnInsertCustomer";
            this.btnInsertCustomer.Size = new System.Drawing.Size(170, 48);
            this.btnInsertCustomer.TabIndex = 1;
            this.btnInsertCustomer.Text = "Insert Customer";
            this.btnInsertCustomer.UseVisualStyleBackColor = false;
            this.btnInsertCustomer.Click += new System.EventHandler(this.btnInsertCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(229, 554);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(170, 36);
            this.btnDeleteCustomer.TabIndex = 2;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(415, 554);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(184, 37);
            this.btnUpdateCustomer.TabIndex = 3;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnShowCustomer
            // 
            this.btnShowCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShowCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCustomer.Location = new System.Drawing.Point(24, 7);
            this.btnShowCustomer.Name = "btnShowCustomer";
            this.btnShowCustomer.Size = new System.Drawing.Size(147, 59);
            this.btnShowCustomer.TabIndex = 4;
            this.btnShowCustomer.Text = "Show Customer";
            this.btnShowCustomer.UseVisualStyleBackColor = false;
            this.btnShowCustomer.Click += new System.EventHandler(this.btnShowCustomer_Click);
            // 
            // btnShowMovies
            // 
            this.btnShowMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShowMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowMovies.Location = new System.Drawing.Point(211, 8);
            this.btnShowMovies.Name = "btnShowMovies";
            this.btnShowMovies.Size = new System.Drawing.Size(127, 61);
            this.btnShowMovies.TabIndex = 5;
            this.btnShowMovies.Text = "Show Movies";
            this.btnShowMovies.UseVisualStyleBackColor = false;
            this.btnShowMovies.Click += new System.EventHandler(this.btnShowMovies_Click);
            // 
            // btnShowRentedMovies
            // 
            this.btnShowRentedMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShowRentedMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRentedMovies.Location = new System.Drawing.Point(384, 7);
            this.btnShowRentedMovies.Name = "btnShowRentedMovies";
            this.btnShowRentedMovies.Size = new System.Drawing.Size(178, 79);
            this.btnShowRentedMovies.TabIndex = 6;
            this.btnShowRentedMovies.Text = "Show Rented Movies";
            this.btnShowRentedMovies.UseVisualStyleBackColor = false;
            this.btnShowRentedMovies.Click += new System.EventHandler(this.btnShowRentedMovies_Click);
            // 
            // btnInsertMovie
            // 
            this.btnInsertMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInsertMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertMovie.Location = new System.Drawing.Point(24, 623);
            this.btnInsertMovie.Name = "btnInsertMovie";
            this.btnInsertMovie.Size = new System.Drawing.Size(160, 37);
            this.btnInsertMovie.TabIndex = 7;
            this.btnInsertMovie.Text = "Insert Movie";
            this.btnInsertMovie.UseVisualStyleBackColor = false;
            this.btnInsertMovie.Click += new System.EventHandler(this.btnInsertMovie_Click);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDeleteMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMovie.Location = new System.Drawing.Point(211, 620);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(162, 40);
            this.btnDeleteMovie.TabIndex = 8;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = false;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdateMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMovie.Location = new System.Drawing.Point(402, 620);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(148, 37);
            this.btnUpdateMovie.TabIndex = 9;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = false;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // btnFamousMovie
            // 
            this.btnFamousMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFamousMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFamousMovie.Location = new System.Drawing.Point(613, 13);
            this.btnFamousMovie.Name = "btnFamousMovie";
            this.btnFamousMovie.Size = new System.Drawing.Size(139, 53);
            this.btnFamousMovie.TabIndex = 10;
            this.btnFamousMovie.Text = "Famous Movie";
            this.btnFamousMovie.UseVisualStyleBackColor = false;
            this.btnFamousMovie.Click += new System.EventHandler(this.btnFamousMovie_Click);
            // 
            // btnFamousCustomer
            // 
            this.btnFamousCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFamousCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFamousCustomer.Location = new System.Drawing.Point(793, 13);
            this.btnFamousCustomer.Name = "btnFamousCustomer";
            this.btnFamousCustomer.Size = new System.Drawing.Size(163, 61);
            this.btnFamousCustomer.TabIndex = 11;
            this.btnFamousCustomer.Text = "Famous Customer";
            this.btnFamousCustomer.UseVisualStyleBackColor = false;
            this.btnFamousCustomer.Click += new System.EventHandler(this.btnFamousCustomer_Click);
            // 
            // btnIssueMovie
            // 
            this.btnIssueMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIssueMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueMovie.Location = new System.Drawing.Point(1009, 23);
            this.btnIssueMovie.Name = "btnIssueMovie";
            this.btnIssueMovie.Size = new System.Drawing.Size(131, 37);
            this.btnIssueMovie.TabIndex = 12;
            this.btnIssueMovie.Text = "Issue Movie";
            this.btnIssueMovie.UseVisualStyleBackColor = false;
            this.btnIssueMovie.Click += new System.EventHandler(this.btnIssueMovie_Click);
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReturnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMovie.Location = new System.Drawing.Point(1177, 24);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(151, 45);
            this.btnReturnMovie.TabIndex = 13;
            this.btnReturnMovie.Text = "Return Movie";
            this.btnReturnMovie.UseVisualStyleBackColor = false;
            this.btnReturnMovie.Click += new System.EventHandler(this.btnReturnMovie_Click);
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDLabel.Location = new System.Drawing.Point(762, 537);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(120, 22);
            this.CustomerIDLabel.TabIndex = 14;
            this.CustomerIDLabel.Text = "Customer ID";
            this.CustomerIDLabel.Click += new System.EventHandler(this.CustomerIDLabel_Click);
            // 
            // FirstNLabel
            // 
            this.FirstNLabel.AutoSize = true;
            this.FirstNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNLabel.Location = new System.Drawing.Point(908, 537);
            this.FirstNLabel.Name = "FirstNLabel";
            this.FirstNLabel.Size = new System.Drawing.Size(101, 22);
            this.FirstNLabel.TabIndex = 15;
            this.FirstNLabel.Text = "FirstName";
            // 
            // LastNLabel
            // 
            this.LastNLabel.AutoSize = true;
            this.LastNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNLabel.Location = new System.Drawing.Point(1036, 537);
            this.LastNLabel.Name = "LastNLabel";
            this.LastNLabel.Size = new System.Drawing.Size(99, 22);
            this.LastNLabel.TabIndex = 16;
            this.LastNLabel.Text = "LastName";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(810, 612);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(83, 22);
            this.AddressLabel.TabIndex = 17;
            this.AddressLabel.Text = "Address";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.Location = new System.Drawing.Point(927, 612);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(67, 22);
            this.PhoneLabel.TabIndex = 18;
            this.PhoneLabel.Text = "Phone";
            // 
            // MovieIDLabel
            // 
            this.MovieIDLabel.AutoSize = true;
            this.MovieIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieIDLabel.Location = new System.Drawing.Point(1069, 612);
            this.MovieIDLabel.Name = "MovieIDLabel";
            this.MovieIDLabel.Size = new System.Drawing.Size(87, 22);
            this.MovieIDLabel.TabIndex = 19;
            this.MovieIDLabel.Text = "Movie ID";
            // 
            // CustomerIDtxtbox
            // 
            this.CustomerIDtxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CustomerIDtxtbox.Location = new System.Drawing.Point(766, 564);
            this.CustomerIDtxtbox.Name = "CustomerIDtxtbox";
            this.CustomerIDtxtbox.Size = new System.Drawing.Size(100, 26);
            this.CustomerIDtxtbox.TabIndex = 20;
            this.CustomerIDtxtbox.TextChanged += new System.EventHandler(this.CustomerIDtxtbox_TextChanged);
            // 
            // FirstNtxtbox
            // 
            this.FirstNtxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FirstNtxtbox.Location = new System.Drawing.Point(901, 565);
            this.FirstNtxtbox.Name = "FirstNtxtbox";
            this.FirstNtxtbox.Size = new System.Drawing.Size(100, 26);
            this.FirstNtxtbox.TabIndex = 22;
            // 
            // LastNtxtbox
            // 
            this.LastNtxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LastNtxtbox.Location = new System.Drawing.Point(1040, 565);
            this.LastNtxtbox.Name = "LastNtxtbox";
            this.LastNtxtbox.Size = new System.Drawing.Size(100, 26);
            this.LastNtxtbox.TabIndex = 23;
            // 
            // Addresstxtbox
            // 
            this.Addresstxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Addresstxtbox.Location = new System.Drawing.Point(793, 646);
            this.Addresstxtbox.Name = "Addresstxtbox";
            this.Addresstxtbox.Size = new System.Drawing.Size(100, 26);
            this.Addresstxtbox.TabIndex = 24;
            // 
            // Phonetxtbox
            // 
            this.Phonetxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Phonetxtbox.Location = new System.Drawing.Point(912, 646);
            this.Phonetxtbox.Name = "Phonetxtbox";
            this.Phonetxtbox.Size = new System.Drawing.Size(100, 26);
            this.Phonetxtbox.TabIndex = 25;
            // 
            // Movietxtbox
            // 
            this.Movietxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Movietxtbox.Location = new System.Drawing.Point(1060, 646);
            this.Movietxtbox.Name = "Movietxtbox";
            this.Movietxtbox.Size = new System.Drawing.Size(100, 26);
            this.Movietxtbox.TabIndex = 26;
            // 
            // Ranklbl
            // 
            this.Ranklbl.AutoSize = true;
            this.Ranklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ranklbl.Location = new System.Drawing.Point(1247, 115);
            this.Ranklbl.Name = "Ranklbl";
            this.Ranklbl.Size = new System.Drawing.Size(56, 22);
            this.Ranklbl.TabIndex = 27;
            this.Ranklbl.Text = "Rank";
            // 
            // Headlinelbl
            // 
            this.Headlinelbl.AutoSize = true;
            this.Headlinelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Headlinelbl.Location = new System.Drawing.Point(1237, 163);
            this.Headlinelbl.Name = "Headlinelbl";
            this.Headlinelbl.Size = new System.Drawing.Size(89, 22);
            this.Headlinelbl.TabIndex = 28;
            this.Headlinelbl.Text = "Headline";
            // 
            // Yearlbl
            // 
            this.Yearlbl.AutoSize = true;
            this.Yearlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yearlbl.Location = new System.Drawing.Point(1190, 218);
            this.Yearlbl.Name = "Yearlbl";
            this.Yearlbl.Size = new System.Drawing.Size(52, 22);
            this.Yearlbl.TabIndex = 29;
            this.Yearlbl.Text = "Year";
            // 
            // RentalChargelbl
            // 
            this.RentalChargelbl.AutoSize = true;
            this.RentalChargelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalChargelbl.Location = new System.Drawing.Point(1196, 260);
            this.RentalChargelbl.Name = "RentalChargelbl";
            this.RentalChargelbl.Size = new System.Drawing.Size(139, 22);
            this.RentalChargelbl.TabIndex = 30;
            this.RentalChargelbl.Text = "Rental Charge";
            // 
            // Copieslbl
            // 
            this.Copieslbl.AutoSize = true;
            this.Copieslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copieslbl.Location = new System.Drawing.Point(1262, 308);
            this.Copieslbl.Name = "Copieslbl";
            this.Copieslbl.Size = new System.Drawing.Size(72, 22);
            this.Copieslbl.TabIndex = 31;
            this.Copieslbl.Text = "Copies";
            // 
            // Plotlbl
            // 
            this.Plotlbl.AutoSize = true;
            this.Plotlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plotlbl.Location = new System.Drawing.Point(1286, 358);
            this.Plotlbl.Name = "Plotlbl";
            this.Plotlbl.Size = new System.Drawing.Size(45, 22);
            this.Plotlbl.TabIndex = 32;
            this.Plotlbl.Text = "Plot";
            // 
            // Categorylbl
            // 
            this.Categorylbl.AutoSize = true;
            this.Categorylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categorylbl.Location = new System.Drawing.Point(1247, 406);
            this.Categorylbl.Name = "Categorylbl";
            this.Categorylbl.Size = new System.Drawing.Size(91, 22);
            this.Categorylbl.TabIndex = 33;
            this.Categorylbl.Text = "Category";
            // 
            // Ranktxtbox
            // 
            this.Ranktxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Ranktxtbox.Location = new System.Drawing.Point(1332, 111);
            this.Ranktxtbox.Name = "Ranktxtbox";
            this.Ranktxtbox.Size = new System.Drawing.Size(100, 26);
            this.Ranktxtbox.TabIndex = 34;
            // 
            // Headlinetxtbox
            // 
            this.Headlinetxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Headlinetxtbox.Location = new System.Drawing.Point(1332, 157);
            this.Headlinetxtbox.Name = "Headlinetxtbox";
            this.Headlinetxtbox.Size = new System.Drawing.Size(100, 26);
            this.Headlinetxtbox.TabIndex = 35;
            this.Headlinetxtbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // RentalChargetxtbox
            // 
            this.RentalChargetxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RentalChargetxtbox.Location = new System.Drawing.Point(1341, 256);
            this.RentalChargetxtbox.Name = "RentalChargetxtbox";
            this.RentalChargetxtbox.Size = new System.Drawing.Size(100, 26);
            this.RentalChargetxtbox.TabIndex = 37;
            // 
            // Copiestxtbox
            // 
            this.Copiestxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Copiestxtbox.Location = new System.Drawing.Point(1351, 302);
            this.Copiestxtbox.Name = "Copiestxtbox";
            this.Copiestxtbox.Size = new System.Drawing.Size(100, 26);
            this.Copiestxtbox.TabIndex = 38;
            // 
            // Plottxtbox
            // 
            this.Plottxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Plottxtbox.Location = new System.Drawing.Point(1351, 352);
            this.Plottxtbox.Name = "Plottxtbox";
            this.Plottxtbox.Size = new System.Drawing.Size(100, 26);
            this.Plottxtbox.TabIndex = 39;
            // 
            // Categorytextbox
            // 
            this.Categorytextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Categorytextbox.Location = new System.Drawing.Point(1351, 402);
            this.Categorytextbox.Name = "Categorytextbox";
            this.Categorytextbox.Size = new System.Drawing.Size(100, 26);
            this.Categorytextbox.TabIndex = 40;
            // 
            // Yeartxtbox
            // 
            this.Yeartxtbox.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Yeartxtbox.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Yeartxtbox.Location = new System.Drawing.Point(1251, 213);
            this.Yeartxtbox.Name = "Yeartxtbox";
            this.Yeartxtbox.Size = new System.Drawing.Size(200, 26);
            this.Yeartxtbox.TabIndex = 0;
            this.Yeartxtbox.ValueChanged += new System.EventHandler(this.Yeartxtbox_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1463, 715);
            this.Controls.Add(this.Yeartxtbox);
            this.Controls.Add(this.Categorytextbox);
            this.Controls.Add(this.Plottxtbox);
            this.Controls.Add(this.Copiestxtbox);
            this.Controls.Add(this.RentalChargetxtbox);
            this.Controls.Add(this.Headlinetxtbox);
            this.Controls.Add(this.Ranktxtbox);
            this.Controls.Add(this.Categorylbl);
            this.Controls.Add(this.Plotlbl);
            this.Controls.Add(this.Copieslbl);
            this.Controls.Add(this.RentalChargelbl);
            this.Controls.Add(this.Yearlbl);
            this.Controls.Add(this.Headlinelbl);
            this.Controls.Add(this.Ranklbl);
            this.Controls.Add(this.Movietxtbox);
            this.Controls.Add(this.Phonetxtbox);
            this.Controls.Add(this.Addresstxtbox);
            this.Controls.Add(this.LastNtxtbox);
            this.Controls.Add(this.FirstNtxtbox);
            this.Controls.Add(this.CustomerIDtxtbox);
            this.Controls.Add(this.MovieIDLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.LastNLabel);
            this.Controls.Add(this.FirstNLabel);
            this.Controls.Add(this.CustomerIDLabel);
            this.Controls.Add(this.btnReturnMovie);
            this.Controls.Add(this.btnIssueMovie);
            this.Controls.Add(this.btnFamousCustomer);
            this.Controls.Add(this.btnFamousMovie);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnInsertMovie);
            this.Controls.Add(this.btnShowRentedMovies);
            this.Controls.Add(this.btnShowMovies);
            this.Controls.Add(this.btnShowCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnInsertCustomer);
            this.Controls.Add(this.dgvCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnInsertCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnShowCustomer;
        private System.Windows.Forms.Button btnShowMovies;
        private System.Windows.Forms.Button btnShowRentedMovies;
        private System.Windows.Forms.Button btnInsertMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnFamousMovie;
        private System.Windows.Forms.Button btnFamousCustomer;
        private System.Windows.Forms.Button btnIssueMovie;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Label FirstNLabel;
        private System.Windows.Forms.Label LastNLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label MovieIDLabel;
        private System.Windows.Forms.TextBox CustomerIDtxtbox;
        private System.Windows.Forms.TextBox FirstNtxtbox;
        private System.Windows.Forms.TextBox LastNtxtbox;
        private System.Windows.Forms.TextBox Addresstxtbox;
        private System.Windows.Forms.TextBox Phonetxtbox;
        private System.Windows.Forms.TextBox Movietxtbox;
        private System.Windows.Forms.Label Ranklbl;
        private System.Windows.Forms.Label Headlinelbl;
        private System.Windows.Forms.Label Yearlbl;
        private System.Windows.Forms.Label RentalChargelbl;
        private System.Windows.Forms.Label Copieslbl;
        private System.Windows.Forms.Label Plotlbl;
        private System.Windows.Forms.Label Categorylbl;
        private System.Windows.Forms.TextBox Ranktxtbox;
        private System.Windows.Forms.TextBox Headlinetxtbox;
        private System.Windows.Forms.TextBox RentalChargetxtbox;
        private System.Windows.Forms.TextBox Copiestxtbox;
        private System.Windows.Forms.TextBox Plottxtbox;
        private System.Windows.Forms.TextBox Categorytextbox;
        private System.Windows.Forms.DateTimePicker Yeartxtbox;
    }
}

