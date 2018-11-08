namespace DvachReader
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Thumbnail = new System.Windows.Forms.PictureBox();
            this.SubjectBox = new System.Windows.Forms.TextBox();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.BoardList = new System.Windows.Forms.ComboBox();
            this.ThreadCount = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // Thumbnail
            // 
            this.Thumbnail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Thumbnail.BackColor = System.Drawing.Color.DarkSalmon;
            this.Thumbnail.Location = new System.Drawing.Point(12, 12);
            this.Thumbnail.Name = "Thumbnail";
            this.Thumbnail.Size = new System.Drawing.Size(300, 150);
            this.Thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Thumbnail.TabIndex = 0;
            this.Thumbnail.TabStop = false;
            // 
            // SubjectBox
            // 
            this.SubjectBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubjectBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.SubjectBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubjectBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubjectBox.Location = new System.Drawing.Point(12, 248);
            this.SubjectBox.Multiline = true;
            this.SubjectBox.Name = "SubjectBox";
            this.SubjectBox.ReadOnly = true;
            this.SubjectBox.Size = new System.Drawing.Size(757, 89);
            this.SubjectBox.TabIndex = 1;
            this.SubjectBox.Text = "Subject";
            this.SubjectBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox
            // 
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBox.Location = new System.Drawing.Point(12, 343);
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.Size = new System.Drawing.Size(757, 279);
            this.TextBox.TabIndex = 2;
            this.TextBox.Text = "Text";
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.Location = new System.Drawing.Point(694, 12);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 32);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "->";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshButton.Location = new System.Drawing.Point(694, 83);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 32);
            this.RefreshButton.TabIndex = 3;
            this.RefreshButton.Text = "@";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // BoardList
            // 
            this.BoardList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BoardList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoardList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BoardList.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoardList.FormattingEnabled = true;
            this.BoardList.Items.AddRange(new object[] {
            "/2d/ - Аниме/Беседка",
            "/8/ - 8bit",
            "/a/ - Аниме",
            "/aa/ - Аниме арт",
            "/abu/ - abu",
            "/alco/ - Алкоголь",
            "/arg/ - ARG/игры в альтернативной реальности",
            "/asmr/ - ASMR",
            "/au/ - Автомобили",
            "/b/ - Бред",
            "/bg/ - Настольные игры",
            "/bi/ - Велосипеды",
            "/biz/ - Бизнес",
            "/bo/ - Книги",
            "/br/ - Барахолка",
            "/brg/ - Браузерные игры",
            "/by/ - Беларусь",
            "/c/ - Комиксы и мультфильмы",
            "/cc/ - Криптовалюта",
            "/cg/ - Консоли",
            "/ch/ - Чатики и конфочки",
            "/char/ - Сетевые персонажи",
            "/crypt/ - Криптоанархия",
            "/cul/ - Культура",
            "/cute/ - Милое",
            "/de/ - Дизайн",
            "/di/ - Столовая",
            "/diy/ - Хобби",
            "/dom/ - Домострой",
            "/dr/ - Дневнички",
            "/e/ - Extreme Pron",
            "/electrach/ - Электронная музыка",
            "/em/ - Другие страны",
            "/es/ - Бесконечное Лето",
            "/ew/ - Конец света",
            "/fa/ - Мода и стиль",
            "/fag/ - Фагготрия",
            "/fd/ - Фэндом",
            "/fem/ - Феминизм",
            "/fet/ - Фетиш",
            "/fg/ - Трапы",
            "/fi/ - Рыбалка",
            "/fiz/ - Физкультура",
            "/fl/ - Иностранные языки",
            "/fs/ - Фэнтези",
            "/ftb/ - Футбол",
            "/fur/ - Фурри",
            "/ga/ - Геи",
            "/gabe/ - Gabe Logan Newell",
            "/gb/ - Азартные игры",
            "/gd/ - Gamedev",
            "/gg/ - Хорошие девушки",
            "/got/ - Песнь льда и пламени",
            "/gsg/ - Grand Strategy Games",
            "/guro/ - Шок-контент",
            "/h/ - Хентай",
            "/hc/ - Hardcore",
            "/hg/ - Хентайные игры/hentai games",
            "/hh/ - Hip-Hop",
            "/hi/ - История",
            "/ho/ - Прочий хентай",
            "/hv/ - Халява в интернете",
            "/hw/ - Компьютерное железо",
            "/ind/ - Инди",
            "/ing/ - Инженерное дело",
            "/int/ - International",
            "/izd/ - Графомания",
            "/ja/ - Японская культура",
            "/jsf/ - Japanese Street Fashion",
            "/kpop/ - K-pop",
            "/kz/ - Казачан",
            "/lap/ - Лапник (4x4 клуб)",
            "/law/ - Право и правоприменители",
            "/ld/ - Осознанные сновидения",
            "/m/ - Меха",
            "/ma/ - Манга",
            "/math/ - Математика",
            "/mc/ - Minecraft",
            "/me/ - Медицина",
            "/media/ - Анимация",
            "/mg/ - Магия",
            "/mlp/ - My Little Pony",
            "/mlpr/ - My Little Pony Roleplay",
            "/mmo/ - Massive multiplayer online games",
            "/mo/ - Мотоциклы",
            "/moba/ - Multiplayer Online Battle Arena games",
            "/mobi/ - Мобильные устройства и приложения",
            "/mov/ - Фильмы",
            "/mu/ - Музыка",
            "/mus/ - Музыканты",
            "/ne/ - Животные и природа",
            "/news/ - Новости",
            "/nvr/ - Новороссия: ЛНР, ДНР",
            "/o/ - Рисовач",
            "/obr/ - Offline Battle Rap",
            "/old/ - Олдфаги",
            "/out/ - Активный отдых",
            "/p/ - Фотография",
            "/pa/ - Живопись",
            "/ph/ - Философия",
            "/po/ - Политика",
            "/pok/ - Pokemon",
            "/pr/ - Программирование",
            "/psy/ - Психология и психиатрия",
            "/pvc/ - Фигурки",
            "/qtr4/ - qtr4",
            "/r/ - Просьбы",
            "/r34/ - Правило 34",
            "/ra/ - Радиотехника",
            "/re/ - Религия",
            "/rf/ - Убежище",
            "/rm/ - Rozen Maiden",
            "/ro/ - Рогалики",
            "/ruvn/ - Российские визуальные новеллы",
            "/s/ - Программы",
            "/sad/ - Садоводство",
            "/sci/ - Наука",
            "/se/ - Самообразование",
            "/sex/ - Секс и отношения",
            "/sf/ - Научная фантастика",
            "/smo/ - Курение",
            "/sn/ - Паранормальные явления",
            "/soc/ - Общение",
            "/socionics/ - Соционика и психософия",
            "/sp/ - Спорт",
            "/spc/ - Космос и астрономия",
            "/srv/ - Серверы",
            "/sw/ - Star Wars",
            "/t/ - Техника",
            "/td/ - Трёхмерная графика",
            "/tes/ - The Elder Scrolls",
            "/to/ - Touhou",
            "/tr/ - Транспорт и авиация",
            "/trv/ - Путешествия и отдых",
            "/tv/ - Сериалы",
            "/ukr/ - /Ukr/aine — Україна",
            "/un/ - Образование",
            "/ussr/ - СССР",
            "/v/ - Video Games",
            "/vape/ - Электронные сигареты",
            "/vg/ - Video Games General",
            "/vn/ - Визуальные новеллы",
            "/vr/ - Виртуальная реальность",
            "/w/ - Оружие",
            "/web/ - Web-мастера",
            "/wh/ - Warhammer",
            "/who/ - Doctor Who",
            "/wm/ - Военная техника",
            "/wow/ - World of Warcraft",
            "/wp/ - Обои и высокое разрешение",
            "/wr/ - Текстовые авторские рпг",
            "/wrk/ - Работа и карьера",
            "/wwe/ - WorldWide Wrestling Universe",
            "/ya/ - Яой",
            "/zog/ - Теории заговора"});
            this.BoardList.Location = new System.Drawing.Point(445, 12);
            this.BoardList.MaxDropDownItems = 10;
            this.BoardList.Name = "BoardList";
            this.BoardList.Size = new System.Drawing.Size(243, 21);
            this.BoardList.TabIndex = 4;
            // 
            // ThreadCount
            // 
            this.ThreadCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ThreadCount.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThreadCount.Location = new System.Drawing.Point(340, 9);
            this.ThreadCount.Name = "ThreadCount";
            this.ThreadCount.Size = new System.Drawing.Size(99, 27);
            this.ThreadCount.TabIndex = 5;
            this.ThreadCount.Text = "1/211";
            this.ThreadCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(694, 45);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 32);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "<-";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(781, 634);
            this.Controls.Add(this.ThreadCount);
            this.Controls.Add(this.BoardList);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.SubjectBox);
            this.Controls.Add(this.Thumbnail);
            this.MinimumSize = new System.Drawing.Size(797, 673);
            this.Name = "Form1";
            this.Text = "2ch Reader";
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Thumbnail;
        private System.Windows.Forms.TextBox SubjectBox;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ComboBox BoardList;
        private System.Windows.Forms.Label ThreadCount;
        private System.Windows.Forms.Button BackButton;
    }
}

