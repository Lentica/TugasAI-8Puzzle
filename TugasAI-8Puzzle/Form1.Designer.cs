namespace TugasAI_8Puzzle
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
            this.gbGoalState = new System.Windows.Forms.GroupBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.gbStartState = new System.Windows.Forms.GroupBox();
            this.btnT0 = new System.Windows.Forms.Button();
            this.btnT8 = new System.Windows.Forms.Button();
            this.btnT7 = new System.Windows.Forms.Button();
            this.btnT6 = new System.Windows.Forms.Button();
            this.btnT5 = new System.Windows.Forms.Button();
            this.btnT4 = new System.Windows.Forms.Button();
            this.btnT3 = new System.Windows.Forms.Button();
            this.btnT2 = new System.Windows.Forms.Button();
            this.btnT1 = new System.Windows.Forms.Button();
            this.gbSolution = new System.Windows.Forms.GroupBox();
            this.btnS0 = new System.Windows.Forms.Button();
            this.btnS8 = new System.Windows.Forms.Button();
            this.btnS7 = new System.Windows.Forms.Button();
            this.btnS6 = new System.Windows.Forms.Button();
            this.btnS5 = new System.Windows.Forms.Button();
            this.btnS4 = new System.Windows.Forms.Button();
            this.btnS3 = new System.Windows.Forms.Button();
            this.btnS2 = new System.Windows.Forms.Button();
            this.btnS1 = new System.Windows.Forms.Button();
            this.gbMethod = new System.Windows.Forms.GroupBox();
            this.rbMethod3 = new System.Windows.Forms.RadioButton();
            this.rbMethod2 = new System.Windows.Forms.RadioButton();
            this.rbMethod1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSteps = new System.Windows.Forms.Label();
            this.labelIteration = new System.Windows.Forms.Label();
            this.labelStepCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrevStep = new System.Windows.Forms.Button();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.gbProgress = new System.Windows.Forms.GroupBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSolve = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.gbGoalState.SuspendLayout();
            this.gbStartState.SuspendLayout();
            this.gbSolution.SuspendLayout();
            this.gbMethod.SuspendLayout();
            this.gbProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGoalState
            // 
            this.gbGoalState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbGoalState.Controls.Add(this.btn0);
            this.gbGoalState.Controls.Add(this.btn8);
            this.gbGoalState.Controls.Add(this.btn7);
            this.gbGoalState.Controls.Add(this.btn3);
            this.gbGoalState.Controls.Add(this.btn2);
            this.gbGoalState.Controls.Add(this.btn6);
            this.gbGoalState.Controls.Add(this.btn5);
            this.gbGoalState.Controls.Add(this.btn1);
            this.gbGoalState.Controls.Add(this.btn4);
            this.gbGoalState.Location = new System.Drawing.Point(337, 68);
            this.gbGoalState.Name = "gbGoalState";
            this.gbGoalState.Size = new System.Drawing.Size(325, 341);
            this.gbGoalState.TabIndex = 0;
            this.gbGoalState.TabStop = false;
            this.gbGoalState.Text = "Goal State";
            // 
            // btn0
            // 
            this.btn0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn0.Location = new System.Drawing.Point(6, 19);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(100, 100);
            this.btn0.TabIndex = 8;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn8.Location = new System.Drawing.Point(218, 231);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(100, 100);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn7.Location = new System.Drawing.Point(112, 231);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(100, 100);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn3.Location = new System.Drawing.Point(6, 125);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(100, 100);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn2.Location = new System.Drawing.Point(219, 19);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 100);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn6.Location = new System.Drawing.Point(6, 231);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(100, 100);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn5.Location = new System.Drawing.Point(218, 125);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(100, 100);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1.Location = new System.Drawing.Point(112, 19);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 100);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn4.Location = new System.Drawing.Point(112, 125);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(100, 100);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // gbStartState
            // 
            this.gbStartState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbStartState.Controls.Add(this.btnT0);
            this.gbStartState.Controls.Add(this.btnT8);
            this.gbStartState.Controls.Add(this.btnT7);
            this.gbStartState.Controls.Add(this.btnT6);
            this.gbStartState.Controls.Add(this.btnT5);
            this.gbStartState.Controls.Add(this.btnT4);
            this.gbStartState.Controls.Add(this.btnT3);
            this.gbStartState.Controls.Add(this.btnT2);
            this.gbStartState.Controls.Add(this.btnT1);
            this.gbStartState.Location = new System.Drawing.Point(6, 68);
            this.gbStartState.Name = "gbStartState";
            this.gbStartState.Size = new System.Drawing.Size(325, 341);
            this.gbStartState.TabIndex = 8;
            this.gbStartState.TabStop = false;
            this.gbStartState.Text = "Start State";
            // 
            // btnT0
            // 
            this.btnT0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnT0.Location = new System.Drawing.Point(6, 19);
            this.btnT0.Name = "btnT0";
            this.btnT0.Size = new System.Drawing.Size(100, 100);
            this.btnT0.TabIndex = 9;
            this.btnT0.Text = "0";
            this.btnT0.UseVisualStyleBackColor = true;
            // 
            // btnT8
            // 
            this.btnT8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnT8.Location = new System.Drawing.Point(218, 231);
            this.btnT8.Name = "btnT8";
            this.btnT8.Size = new System.Drawing.Size(100, 100);
            this.btnT8.TabIndex = 7;
            this.btnT8.Text = "8";
            this.btnT8.UseVisualStyleBackColor = true;
            // 
            // btnT7
            // 
            this.btnT7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnT7.Location = new System.Drawing.Point(112, 231);
            this.btnT7.Name = "btnT7";
            this.btnT7.Size = new System.Drawing.Size(100, 100);
            this.btnT7.TabIndex = 6;
            this.btnT7.Text = "7";
            this.btnT7.UseVisualStyleBackColor = true;
            // 
            // btnT6
            // 
            this.btnT6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnT6.Location = new System.Drawing.Point(6, 231);
            this.btnT6.Name = "btnT6";
            this.btnT6.Size = new System.Drawing.Size(100, 100);
            this.btnT6.TabIndex = 5;
            this.btnT6.Text = "6";
            this.btnT6.UseVisualStyleBackColor = true;
            // 
            // btnT5
            // 
            this.btnT5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnT5.Location = new System.Drawing.Point(218, 125);
            this.btnT5.Name = "btnT5";
            this.btnT5.Size = new System.Drawing.Size(100, 100);
            this.btnT5.TabIndex = 4;
            this.btnT5.Text = "5";
            this.btnT5.UseVisualStyleBackColor = true;
            // 
            // btnT4
            // 
            this.btnT4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnT4.Location = new System.Drawing.Point(112, 125);
            this.btnT4.Name = "btnT4";
            this.btnT4.Size = new System.Drawing.Size(100, 100);
            this.btnT4.TabIndex = 3;
            this.btnT4.Text = "4";
            this.btnT4.UseVisualStyleBackColor = true;
            // 
            // btnT3
            // 
            this.btnT3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnT3.Location = new System.Drawing.Point(6, 125);
            this.btnT3.Name = "btnT3";
            this.btnT3.Size = new System.Drawing.Size(100, 100);
            this.btnT3.TabIndex = 2;
            this.btnT3.Text = "3";
            this.btnT3.UseVisualStyleBackColor = true;
            // 
            // btnT2
            // 
            this.btnT2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnT2.Location = new System.Drawing.Point(219, 19);
            this.btnT2.Name = "btnT2";
            this.btnT2.Size = new System.Drawing.Size(100, 100);
            this.btnT2.TabIndex = 1;
            this.btnT2.Text = "2";
            this.btnT2.UseVisualStyleBackColor = true;
            // 
            // btnT1
            // 
            this.btnT1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnT1.Location = new System.Drawing.Point(112, 19);
            this.btnT1.Name = "btnT1";
            this.btnT1.Size = new System.Drawing.Size(100, 100);
            this.btnT1.TabIndex = 0;
            this.btnT1.Text = "1";
            this.btnT1.UseVisualStyleBackColor = true;
            // 
            // gbSolution
            // 
            this.gbSolution.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbSolution.Controls.Add(this.btnS0);
            this.gbSolution.Controls.Add(this.btnS8);
            this.gbSolution.Controls.Add(this.btnS7);
            this.gbSolution.Controls.Add(this.btnS6);
            this.gbSolution.Controls.Add(this.btnS5);
            this.gbSolution.Controls.Add(this.btnS4);
            this.gbSolution.Controls.Add(this.btnS3);
            this.gbSolution.Controls.Add(this.btnS2);
            this.gbSolution.Controls.Add(this.btnS1);
            this.gbSolution.Location = new System.Drawing.Point(850, 68);
            this.gbSolution.Name = "gbSolution";
            this.gbSolution.Size = new System.Drawing.Size(325, 341);
            this.gbSolution.TabIndex = 9;
            this.gbSolution.TabStop = false;
            this.gbSolution.Text = "gbSolution";
            // 
            // btnS0
            // 
            this.btnS0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnS0.Location = new System.Drawing.Point(6, 19);
            this.btnS0.Name = "btnS0";
            this.btnS0.Size = new System.Drawing.Size(100, 100);
            this.btnS0.TabIndex = 8;
            this.btnS0.Text = "0";
            this.btnS0.UseVisualStyleBackColor = true;
            // 
            // btnS8
            // 
            this.btnS8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnS8.Location = new System.Drawing.Point(218, 231);
            this.btnS8.Name = "btnS8";
            this.btnS8.Size = new System.Drawing.Size(100, 100);
            this.btnS8.TabIndex = 7;
            this.btnS8.Text = "8";
            this.btnS8.UseVisualStyleBackColor = true;
            // 
            // btnS7
            // 
            this.btnS7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnS7.Location = new System.Drawing.Point(112, 231);
            this.btnS7.Name = "btnS7";
            this.btnS7.Size = new System.Drawing.Size(100, 100);
            this.btnS7.TabIndex = 6;
            this.btnS7.Text = "7";
            this.btnS7.UseVisualStyleBackColor = true;
            // 
            // btnS6
            // 
            this.btnS6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnS6.Location = new System.Drawing.Point(6, 231);
            this.btnS6.Name = "btnS6";
            this.btnS6.Size = new System.Drawing.Size(100, 100);
            this.btnS6.TabIndex = 5;
            this.btnS6.Text = "6";
            this.btnS6.UseVisualStyleBackColor = true;
            // 
            // btnS5
            // 
            this.btnS5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnS5.Location = new System.Drawing.Point(219, 125);
            this.btnS5.Name = "btnS5";
            this.btnS5.Size = new System.Drawing.Size(100, 100);
            this.btnS5.TabIndex = 4;
            this.btnS5.Text = "5";
            this.btnS5.UseVisualStyleBackColor = true;
            // 
            // btnS4
            // 
            this.btnS4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnS4.Location = new System.Drawing.Point(112, 125);
            this.btnS4.Name = "btnS4";
            this.btnS4.Size = new System.Drawing.Size(100, 100);
            this.btnS4.TabIndex = 3;
            this.btnS4.Text = "4";
            this.btnS4.UseVisualStyleBackColor = true;
            // 
            // btnS3
            // 
            this.btnS3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnS3.Location = new System.Drawing.Point(6, 125);
            this.btnS3.Name = "btnS3";
            this.btnS3.Size = new System.Drawing.Size(100, 100);
            this.btnS3.TabIndex = 2;
            this.btnS3.Text = "3";
            this.btnS3.UseVisualStyleBackColor = true;
            // 
            // btnS2
            // 
            this.btnS2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnS2.Location = new System.Drawing.Point(218, 19);
            this.btnS2.Name = "btnS2";
            this.btnS2.Size = new System.Drawing.Size(100, 100);
            this.btnS2.TabIndex = 1;
            this.btnS2.Text = "2";
            this.btnS2.UseVisualStyleBackColor = true;
            // 
            // btnS1
            // 
            this.btnS1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnS1.Location = new System.Drawing.Point(112, 19);
            this.btnS1.Name = "btnS1";
            this.btnS1.Size = new System.Drawing.Size(100, 100);
            this.btnS1.TabIndex = 0;
            this.btnS1.Text = "1";
            this.btnS1.UseVisualStyleBackColor = true;
            // 
            // gbMethod
            // 
            this.gbMethod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbMethod.Controls.Add(this.rbMethod3);
            this.gbMethod.Controls.Add(this.rbMethod2);
            this.gbMethod.Controls.Add(this.rbMethod1);
            this.gbMethod.Location = new System.Drawing.Point(6, 12);
            this.gbMethod.Name = "gbMethod";
            this.gbMethod.Size = new System.Drawing.Size(458, 50);
            this.gbMethod.TabIndex = 9;
            this.gbMethod.TabStop = false;
            this.gbMethod.Text = "gbMethod";
            // 
            // rbMethod3
            // 
            this.rbMethod3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbMethod3.AutoSize = true;
            this.rbMethod3.Location = new System.Drawing.Point(367, 19);
            this.rbMethod3.Name = "rbMethod3";
            this.rbMethod3.Size = new System.Drawing.Size(70, 17);
            this.rbMethod3.TabIndex = 2;
            this.rbMethod3.TabStop = true;
            this.rbMethod3.Text = "Method 3";
            this.rbMethod3.UseVisualStyleBackColor = true;
            // 
            // rbMethod2
            // 
            this.rbMethod2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbMethod2.AutoSize = true;
            this.rbMethod2.Location = new System.Drawing.Point(188, 19);
            this.rbMethod2.Name = "rbMethod2";
            this.rbMethod2.Size = new System.Drawing.Size(70, 17);
            this.rbMethod2.TabIndex = 1;
            this.rbMethod2.TabStop = true;
            this.rbMethod2.Text = "Method 2";
            this.rbMethod2.UseVisualStyleBackColor = true;
            // 
            // rbMethod1
            // 
            this.rbMethod1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbMethod1.AutoSize = true;
            this.rbMethod1.Location = new System.Drawing.Point(16, 19);
            this.rbMethod1.Name = "rbMethod1";
            this.rbMethod1.Size = new System.Drawing.Size(70, 17);
            this.rbMethod1.TabIndex = 0;
            this.rbMethod1.TabStop = true;
            this.rbMethod1.Text = "Method 1";
            this.rbMethod1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(847, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Number of steps:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(847, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Number of iteration:";
            // 
            // labelSteps
            // 
            this.labelSteps.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSteps.AutoSize = true;
            this.labelSteps.Location = new System.Drawing.Point(940, 428);
            this.labelSteps.Name = "labelSteps";
            this.labelSteps.Size = new System.Drawing.Size(44, 13);
            this.labelSteps.TabIndex = 12;
            this.labelSteps.Text = "<steps>";
            // 
            // labelIteration
            // 
            this.labelIteration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIteration.AutoSize = true;
            this.labelIteration.Location = new System.Drawing.Point(952, 454);
            this.labelIteration.Name = "labelIteration";
            this.labelIteration.Size = new System.Drawing.Size(56, 13);
            this.labelIteration.TabIndex = 13;
            this.labelIteration.Text = "<iteration>";
            // 
            // labelStepCount
            // 
            this.labelStepCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStepCount.AutoSize = true;
            this.labelStepCount.Location = new System.Drawing.Point(916, 35);
            this.labelStepCount.Name = "labelStepCount";
            this.labelStepCount.Size = new System.Drawing.Size(69, 13);
            this.labelStepCount.TabIndex = 15;
            this.labelStepCount.Text = "<step count>";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(847, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Step Count:";
            // 
            // btnPrevStep
            // 
            this.btnPrevStep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrevStep.Location = new System.Drawing.Point(850, 487);
            this.btnPrevStep.Name = "btnPrevStep";
            this.btnPrevStep.Size = new System.Drawing.Size(75, 23);
            this.btnPrevStep.TabIndex = 16;
            this.btnPrevStep.Text = "Previous";
            this.btnPrevStep.UseVisualStyleBackColor = true;
            // 
            // btnNextStep
            // 
            this.btnNextStep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNextStep.Location = new System.Drawing.Point(943, 487);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(75, 23);
            this.btnNextStep.TabIndex = 17;
            this.btnNextStep.Text = "Next";
            this.btnNextStep.UseVisualStyleBackColor = true;
            // 
            // gbProgress
            // 
            this.gbProgress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbProgress.Controls.Add(this.labelTime);
            this.gbProgress.Controls.Add(this.progressBar1);
            this.gbProgress.Controls.Add(this.label3);
            this.gbProgress.Location = new System.Drawing.Point(6, 428);
            this.gbProgress.Name = "gbProgress";
            this.gbProgress.Size = new System.Drawing.Size(649, 166);
            this.gbProgress.TabIndex = 18;
            this.gbProgress.TabStop = false;
            this.gbProgress.Text = "gbProgress";
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(94, 46);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(38, 13);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "<time>";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar1.Location = new System.Drawing.Point(58, 85);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(572, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Time:";
            // 
            // btnSolve
            // 
            this.btnSolve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.Location = new System.Drawing.Point(702, 204);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(105, 78);
            this.btnSolve.TabIndex = 19;
            this.btnSolve.Text = "SOLVE";
            this.btnSolve.UseVisualStyleBackColor = true;
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbLog.Location = new System.Drawing.Point(850, 516);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(402, 78);
            this.rtbLog.TabIndex = 20;
            this.rtbLog.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.gbProgress);
            this.Controls.Add(this.btnNextStep);
            this.Controls.Add(this.btnPrevStep);
            this.Controls.Add(this.labelStepCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelIteration);
            this.Controls.Add(this.labelSteps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbMethod);
            this.Controls.Add(this.gbSolution);
            this.Controls.Add(this.gbStartState);
            this.Controls.Add(this.gbGoalState);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbGoalState.ResumeLayout(false);
            this.gbStartState.ResumeLayout(false);
            this.gbSolution.ResumeLayout(false);
            this.gbMethod.ResumeLayout(false);
            this.gbMethod.PerformLayout();
            this.gbProgress.ResumeLayout(false);
            this.gbProgress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGoalState;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.GroupBox gbStartState;
        private System.Windows.Forms.Button btnT0;
        private System.Windows.Forms.Button btnT8;
        private System.Windows.Forms.Button btnT7;
        private System.Windows.Forms.Button btnT6;
        private System.Windows.Forms.Button btnT5;
        private System.Windows.Forms.Button btnT4;
        private System.Windows.Forms.Button btnT3;
        private System.Windows.Forms.Button btnT2;
        private System.Windows.Forms.Button btnT1;
        private System.Windows.Forms.GroupBox gbSolution;
        private System.Windows.Forms.Button btnS0;
        private System.Windows.Forms.Button btnS8;
        private System.Windows.Forms.Button btnS7;
        private System.Windows.Forms.Button btnS6;
        private System.Windows.Forms.Button btnS5;
        private System.Windows.Forms.Button btnS4;
        private System.Windows.Forms.Button btnS3;
        private System.Windows.Forms.Button btnS2;
        private System.Windows.Forms.Button btnS1;
        private System.Windows.Forms.GroupBox gbMethod;
        private System.Windows.Forms.RadioButton rbMethod2;
        private System.Windows.Forms.RadioButton rbMethod1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSteps;
        private System.Windows.Forms.Label labelIteration;
        private System.Windows.Forms.Label labelStepCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrevStep;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.GroupBox gbProgress;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbMethod3;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.RichTextBox rtbLog;
    }
}

