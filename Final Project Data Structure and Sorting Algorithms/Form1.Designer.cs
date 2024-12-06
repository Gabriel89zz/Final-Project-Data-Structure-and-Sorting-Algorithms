using System.Xml.Linq;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddNode = new Button();
            txtNode = new TextBox();
            txtFrom = new TextBox();
            txtTo = new TextBox();
            btnAddEdge = new Button();
            btnRemoveEdge = new Button();
            txtGraphRepresentation = new TextBox();
            txtWeight = new TextBox();
            chkDirected = new CheckBox();
            btnShowDFS = new Button();
            txtStartNode = new TextBox();
            btnRemoveNode = new Button();
            btnShowBFS = new Button();
            btnShowDFSRecursive = new Button();
            btnRemoveAll = new Button();
            tabControl1 = new TabControl();
            Lists = new TabPage();
            btnCount = new Button();
            btnContains = new Button();
            btnRemove = new Button();
            btnAdd = new Button();
            label5 = new Label();
            txtValue = new TextBox();
            label3 = new Label();
            lstDoubleCircularList = new ListBox();
            label4 = new Label();
            lstCircularList = new ListBox();
            label2 = new Label();
            lstDoubleList = new ListBox();
            label1 = new Label();
            lstSimpleLinkedList = new ListBox();
            tabPage2 = new TabPage();
            btnSize = new Button();
            btnPeek = new Button();
            btnPop = new Button();
            btnPush = new Button();
            label8 = new Label();
            txtStackValue = new TextBox();
            label7 = new Label();
            lstDynamicStack = new ListBox();
            label6 = new Label();
            lstStaticStack = new ListBox();
            tabPage1 = new TabPage();
            tabControl2 = new TabControl();
            tabPage5 = new TabPage();
            label14 = new Label();
            lstCircularQueue = new ListBox();
            btnSizeQueue = new Button();
            btnPeekQueue = new Button();
            btnDequeue = new Button();
            btnEnqueue = new Button();
            label9 = new Label();
            txtValueSimpleQueue = new TextBox();
            label10 = new Label();
            lstDynamicQueue = new ListBox();
            label11 = new Label();
            lstStaticQueue = new ListBox();
            tabPage6 = new TabPage();
            btnGetRear = new Button();
            btnDeleteRear = new Button();
            btnInsertRear = new Button();
            label13 = new Label();
            lstQueueDoubleList = new ListBox();
            label15 = new Label();
            lstQueueDobleVector = new ListBox();
            btnSizeDoubleQueue = new Button();
            btnGetFront = new Button();
            btnDeleteFront = new Button();
            btnInsertFront = new Button();
            label12 = new Label();
            txtQueueDoubleValue = new TextBox();
            tabPage7 = new TabPage();
            label21 = new Label();
            txtPriorityQueueLevel = new TextBox();
            btnPriorityQueueSize = new Button();
            btnPeekPriorityQueue = new Button();
            btnDequeuePriorityQueue = new Button();
            btnEnqueuePriorityQueue = new Button();
            label17 = new Label();
            lstPriorityQueueLL = new ListBox();
            label18 = new Label();
            lstPriorityQueueLV = new ListBox();
            label19 = new Label();
            lstPriorityQueueVL = new ListBox();
            label20 = new Label();
            lstPriorityQueueVV = new ListBox();
            label16 = new Label();
            txtQueuePriorityValue = new TextBox();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label22 = new Label();
            label23 = new Label();
            tabPage8 = new TabPage();
            lstNumbersSort = new ListBox();
            cmbAlgoritms = new ComboBox();
            btnSort = new Button();
            btnSetNumbers = new Button();
            lstAux = new ListBox();
            tabControl1.SuspendLayout();
            Lists.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage7.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage8.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddNode
            // 
            btnAddNode.Location = new Point(171, 88);
            btnAddNode.Name = "btnAddNode";
            btnAddNode.Size = new Size(75, 23);
            btnAddNode.TabIndex = 1;
            btnAddNode.Text = "Add Node";
            btnAddNode.UseVisualStyleBackColor = true;
            btnAddNode.Click += btnAddNode_Click;
            // 
            // txtNode
            // 
            txtNode.Location = new Point(161, 55);
            txtNode.Name = "txtNode";
            txtNode.Size = new Size(180, 23);
            txtNode.TabIndex = 2;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(152, 185);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(104, 23);
            txtFrom.TabIndex = 4;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(152, 223);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(104, 23);
            txtTo.TabIndex = 6;
            // 
            // btnAddEdge
            // 
            btnAddEdge.Location = new Point(289, 185);
            btnAddEdge.Name = "btnAddEdge";
            btnAddEdge.Size = new Size(75, 23);
            btnAddEdge.TabIndex = 8;
            btnAddEdge.Text = "Add Edge";
            btnAddEdge.UseVisualStyleBackColor = true;
            btnAddEdge.Click += btnAddEdge_Click;
            // 
            // btnRemoveEdge
            // 
            btnRemoveEdge.Location = new Point(289, 223);
            btnRemoveEdge.Name = "btnRemoveEdge";
            btnRemoveEdge.Size = new Size(75, 39);
            btnRemoveEdge.TabIndex = 9;
            btnRemoveEdge.Text = "Remove Edge";
            btnRemoveEdge.UseVisualStyleBackColor = true;
            btnRemoveEdge.Click += btnRemoveEdge_Click;
            // 
            // txtGraphRepresentation
            // 
            txtGraphRepresentation.Font = new Font("Yu Gothic Medium", 11F);
            txtGraphRepresentation.Location = new Point(512, 70);
            txtGraphRepresentation.Multiline = true;
            txtGraphRepresentation.Name = "txtGraphRepresentation";
            txtGraphRepresentation.Size = new Size(362, 202);
            txtGraphRepresentation.TabIndex = 12;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(152, 257);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(104, 23);
            txtWeight.TabIndex = 13;
            // 
            // chkDirected
            // 
            chkDirected.AutoSize = true;
            chkDirected.Location = new Point(152, 286);
            chkDirected.Name = "chkDirected";
            chkDirected.Size = new Size(70, 19);
            chkDirected.TabIndex = 15;
            chkDirected.Text = "Directed";
            chkDirected.UseVisualStyleBackColor = true;
            // 
            // btnShowDFS
            // 
            btnShowDFS.Location = new Point(160, 415);
            btnShowDFS.Name = "btnShowDFS";
            btnShowDFS.Size = new Size(75, 39);
            btnShowDFS.TabIndex = 16;
            btnShowDFS.Text = "Show DFS Algorithm";
            btnShowDFS.UseVisualStyleBackColor = true;
            btnShowDFS.Click += btnShowDFS_Click;
            // 
            // txtStartNode
            // 
            txtStartNode.Location = new Point(183, 386);
            txtStartNode.Name = "txtStartNode";
            txtStartNode.Size = new Size(104, 23);
            txtStartNode.TabIndex = 17;
            // 
            // btnRemoveNode
            // 
            btnRemoveNode.Location = new Point(266, 88);
            btnRemoveNode.Name = "btnRemoveNode";
            btnRemoveNode.Size = new Size(75, 23);
            btnRemoveNode.TabIndex = 20;
            btnRemoveNode.Text = "Remove";
            btnRemoveNode.UseVisualStyleBackColor = true;
            btnRemoveNode.Click += btnRemoveNode_Click;
            // 
            // btnShowBFS
            // 
            btnShowBFS.Location = new Point(79, 415);
            btnShowBFS.Name = "btnShowBFS";
            btnShowBFS.Size = new Size(75, 39);
            btnShowBFS.TabIndex = 21;
            btnShowBFS.Text = "Show BFS Algorithm";
            btnShowBFS.UseVisualStyleBackColor = true;
            btnShowBFS.Click += btnShowBFS_Click;
            // 
            // btnShowDFSRecursive
            // 
            btnShowDFSRecursive.Location = new Point(241, 415);
            btnShowDFSRecursive.Name = "btnShowDFSRecursive";
            btnShowDFSRecursive.Size = new Size(75, 39);
            btnShowDFSRecursive.TabIndex = 23;
            btnShowDFSRecursive.Text = "Show DFS Recursive Algorithm";
            btnShowDFSRecursive.UseVisualStyleBackColor = true;
            btnShowDFSRecursive.Click += btnShowDFSRecursive_Click;
            // 
            // btnRemoveAll
            // 
            btnRemoveAll.Location = new Point(512, 41);
            btnRemoveAll.Name = "btnRemoveAll";
            btnRemoveAll.Size = new Size(84, 23);
            btnRemoveAll.TabIndex = 24;
            btnRemoveAll.Text = "Remove All";
            btnRemoveAll.UseVisualStyleBackColor = true;
            btnRemoveAll.Click += btnRemoveAll_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Lists);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage8);
            tabControl1.Location = new Point(-2, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(918, 520);
            tabControl1.TabIndex = 0;
            // 
            // Lists
            // 
            Lists.Controls.Add(btnCount);
            Lists.Controls.Add(btnContains);
            Lists.Controls.Add(btnRemove);
            Lists.Controls.Add(btnAdd);
            Lists.Controls.Add(label5);
            Lists.Controls.Add(txtValue);
            Lists.Controls.Add(label3);
            Lists.Controls.Add(lstDoubleCircularList);
            Lists.Controls.Add(label4);
            Lists.Controls.Add(lstCircularList);
            Lists.Controls.Add(label2);
            Lists.Controls.Add(lstDoubleList);
            Lists.Controls.Add(label1);
            Lists.Controls.Add(lstSimpleLinkedList);
            Lists.Location = new Point(4, 24);
            Lists.Name = "Lists";
            Lists.Padding = new Padding(3);
            Lists.Size = new Size(910, 492);
            Lists.TabIndex = 0;
            Lists.Text = "Lists";
            Lists.UseVisualStyleBackColor = true;
            // 
            // btnCount
            // 
            btnCount.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCount.Location = new Point(206, 223);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(96, 42);
            btnCount.TabIndex = 13;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // btnContains
            // 
            btnContains.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContains.Location = new Point(206, 158);
            btnContains.Name = "btnContains";
            btnContains.Size = new Size(96, 42);
            btnContains.TabIndex = 12;
            btnContains.Text = "Contains";
            btnContains.UseVisualStyleBackColor = true;
            btnContains.Click += btnContains_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(206, 93);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(96, 42);
            btnRemove.TabIndex = 11;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(206, 29);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 42);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(79, 29);
            label5.Name = "label5";
            label5.Size = new Size(66, 22);
            label5.TabIndex = 9;
            label5.Text = "Value:";
            // 
            // txtValue
            // 
            txtValue.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValue.Location = new Point(51, 54);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(119, 30);
            txtValue.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold);
            label3.Location = new Point(656, 243);
            label3.Name = "label3";
            label3.Size = new Size(190, 22);
            label3.TabIndex = 7;
            label3.Text = "Double Circular List";
            // 
            // lstDoubleCircularList
            // 
            lstDoubleCircularList.Font = new Font("Swis721 Lt BT", 14.25F);
            lstDoubleCircularList.FormattingEnabled = true;
            lstDoubleCircularList.ItemHeight = 22;
            lstDoubleCircularList.Location = new Point(692, 277);
            lstDoubleCircularList.Name = "lstDoubleCircularList";
            lstDoubleCircularList.Size = new Size(116, 158);
            lstDoubleCircularList.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold);
            label4.Location = new Point(473, 243);
            label4.Name = "label4";
            label4.Size = new Size(119, 22);
            label4.TabIndex = 5;
            label4.Text = "Circular List";
            // 
            // lstCircularList
            // 
            lstCircularList.Font = new Font("Swis721 Lt BT", 14.25F);
            lstCircularList.FormattingEnabled = true;
            lstCircularList.ItemHeight = 22;
            lstCircularList.Location = new Point(486, 277);
            lstCircularList.Name = "lstCircularList";
            lstCircularList.Size = new Size(116, 158);
            lstCircularList.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold);
            label2.Location = new Point(692, 20);
            label2.Name = "label2";
            label2.Size = new Size(113, 22);
            label2.TabIndex = 3;
            label2.Text = "Double List";
            // 
            // lstDoubleList
            // 
            lstDoubleList.Font = new Font("Swis721 Lt BT", 14.25F);
            lstDoubleList.FormattingEnabled = true;
            lstDoubleList.ItemHeight = 22;
            lstDoubleList.Location = new Point(692, 54);
            lstDoubleList.Name = "lstDoubleList";
            lstDoubleList.Size = new Size(116, 158);
            lstDoubleList.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold);
            label1.Location = new Point(463, 20);
            label1.Name = "label1";
            label1.Size = new Size(171, 22);
            label1.TabIndex = 1;
            label1.Text = "Simple LinkedList";
            // 
            // lstSimpleLinkedList
            // 
            lstSimpleLinkedList.Font = new Font("Swis721 Lt BT", 14.25F);
            lstSimpleLinkedList.FormattingEnabled = true;
            lstSimpleLinkedList.ItemHeight = 22;
            lstSimpleLinkedList.Location = new Point(486, 54);
            lstSimpleLinkedList.Name = "lstSimpleLinkedList";
            lstSimpleLinkedList.Size = new Size(116, 158);
            lstSimpleLinkedList.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnSize);
            tabPage2.Controls.Add(btnPeek);
            tabPage2.Controls.Add(btnPop);
            tabPage2.Controls.Add(btnPush);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txtStackValue);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(lstDynamicStack);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(lstStaticStack);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(910, 492);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Stacks";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSize
            // 
            btnSize.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSize.Location = new Point(193, 249);
            btnSize.Name = "btnSize";
            btnSize.Size = new Size(96, 42);
            btnSize.TabIndex = 15;
            btnSize.Text = "Size";
            btnSize.UseVisualStyleBackColor = true;
            btnSize.Click += btnSize_Click;
            // 
            // btnPeek
            // 
            btnPeek.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPeek.Location = new Point(193, 185);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(96, 42);
            btnPeek.TabIndex = 14;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = true;
            btnPeek.Click += btnPeek_Click;
            // 
            // btnPop
            // 
            btnPop.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPop.Location = new Point(193, 118);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(96, 42);
            btnPop.TabIndex = 13;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnPop_Click;
            // 
            // btnPush
            // 
            btnPush.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPush.Location = new Point(193, 54);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(96, 42);
            btnPush.TabIndex = 12;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(55, 31);
            label8.Name = "label8";
            label8.Size = new Size(66, 22);
            label8.TabIndex = 11;
            label8.Text = "Value:";
            // 
            // txtStackValue
            // 
            txtStackValue.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStackValue.Location = new Point(27, 56);
            txtStackValue.Name = "txtStackValue";
            txtStackValue.Size = new Size(119, 30);
            txtStackValue.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold);
            label7.Location = new Point(680, 74);
            label7.Name = "label7";
            label7.Size = new Size(146, 22);
            label7.TabIndex = 5;
            label7.Text = "Dynamic Stack";
            // 
            // lstDynamicStack
            // 
            lstDynamicStack.Font = new Font("Swis721 Lt BT", 14.25F);
            lstDynamicStack.FormattingEnabled = true;
            lstDynamicStack.ItemHeight = 22;
            lstDynamicStack.Location = new Point(696, 99);
            lstDynamicStack.Name = "lstDynamicStack";
            lstDynamicStack.Size = new Size(119, 268);
            lstDynamicStack.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold);
            label6.Location = new Point(457, 74);
            label6.Name = "label6";
            label6.Size = new Size(119, 22);
            label6.TabIndex = 3;
            label6.Text = "Static Stack";
            // 
            // lstStaticStack
            // 
            lstStaticStack.Font = new Font("Swis721 Lt BT", 14.25F);
            lstStaticStack.FormattingEnabled = true;
            lstStaticStack.ItemHeight = 22;
            lstStaticStack.Location = new Point(457, 99);
            lstStaticStack.Name = "lstStaticStack";
            lstStaticStack.Size = new Size(119, 268);
            lstStaticStack.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tabControl2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(910, 492);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Queues";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage5);
            tabControl2.Controls.Add(tabPage6);
            tabControl2.Controls.Add(tabPage7);
            tabControl2.Location = new Point(-1, -2);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(911, 493);
            tabControl2.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label14);
            tabPage5.Controls.Add(lstCircularQueue);
            tabPage5.Controls.Add(btnSizeQueue);
            tabPage5.Controls.Add(btnPeekQueue);
            tabPage5.Controls.Add(btnDequeue);
            tabPage5.Controls.Add(btnEnqueue);
            tabPage5.Controls.Add(label9);
            tabPage5.Controls.Add(txtValueSimpleQueue);
            tabPage5.Controls.Add(label10);
            tabPage5.Controls.Add(lstDynamicQueue);
            tabPage5.Controls.Add(label11);
            tabPage5.Controls.Add(lstStaticQueue);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(903, 465);
            tabPage5.TabIndex = 0;
            tabPage5.Text = "Simple and Circular";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold);
            label14.Location = new Point(727, 62);
            label14.Name = "label14";
            label14.Size = new Size(146, 22);
            label14.TabIndex = 29;
            label14.Text = "Circular Queue";
            // 
            // lstCircularQueue
            // 
            lstCircularQueue.Font = new Font("Swis721 Lt BT", 14.25F);
            lstCircularQueue.FormattingEnabled = true;
            lstCircularQueue.ItemHeight = 22;
            lstCircularQueue.Location = new Point(740, 87);
            lstCircularQueue.Name = "lstCircularQueue";
            lstCircularQueue.Size = new Size(119, 268);
            lstCircularQueue.TabIndex = 28;
            // 
            // btnSizeQueue
            // 
            btnSizeQueue.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSizeQueue.Location = new Point(218, 282);
            btnSizeQueue.Name = "btnSizeQueue";
            btnSizeQueue.Size = new Size(96, 42);
            btnSizeQueue.TabIndex = 25;
            btnSizeQueue.Text = "Size";
            btnSizeQueue.UseVisualStyleBackColor = true;
            btnSizeQueue.Click += btnSizeQueue_Click;
            // 
            // btnPeekQueue
            // 
            btnPeekQueue.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPeekQueue.Location = new Point(218, 218);
            btnPeekQueue.Name = "btnPeekQueue";
            btnPeekQueue.Size = new Size(96, 42);
            btnPeekQueue.TabIndex = 24;
            btnPeekQueue.Text = "Peek";
            btnPeekQueue.UseVisualStyleBackColor = true;
            btnPeekQueue.Click += btnPeekQueue_Click;
            // 
            // btnDequeue
            // 
            btnDequeue.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDequeue.Location = new Point(218, 151);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(96, 42);
            btnDequeue.TabIndex = 23;
            btnDequeue.Text = "Dequeue";
            btnDequeue.UseVisualStyleBackColor = true;
            btnDequeue.Click += btnDequeue_Click;
            // 
            // btnEnqueue
            // 
            btnEnqueue.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnqueue.Location = new Point(218, 87);
            btnEnqueue.Name = "btnEnqueue";
            btnEnqueue.Size = new Size(96, 42);
            btnEnqueue.TabIndex = 22;
            btnEnqueue.Text = "Enqueue";
            btnEnqueue.UseVisualStyleBackColor = true;
            btnEnqueue.Click += btnEnqueue_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(48, 29);
            label9.Name = "label9";
            label9.Size = new Size(66, 22);
            label9.TabIndex = 21;
            label9.Text = "Value:";
            // 
            // txtValueSimpleQueue
            // 
            txtValueSimpleQueue.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValueSimpleQueue.Location = new Point(20, 54);
            txtValueSimpleQueue.Name = "txtValueSimpleQueue";
            txtValueSimpleQueue.Size = new Size(119, 30);
            txtValueSimpleQueue.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold);
            label10.Location = new Point(549, 62);
            label10.Name = "label10";
            label10.Size = new Size(154, 22);
            label10.TabIndex = 19;
            label10.Text = "Dynamic Queue";
            // 
            // lstDynamicQueue
            // 
            lstDynamicQueue.Font = new Font("Swis721 Lt BT", 14.25F);
            lstDynamicQueue.FormattingEnabled = true;
            lstDynamicQueue.ItemHeight = 22;
            lstDynamicQueue.Location = new Point(570, 87);
            lstDynamicQueue.Name = "lstDynamicQueue";
            lstDynamicQueue.Size = new Size(119, 268);
            lstDynamicQueue.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold);
            label11.Location = new Point(400, 62);
            label11.Name = "label11";
            label11.Size = new Size(127, 22);
            label11.TabIndex = 17;
            label11.Text = "Static Queue";
            // 
            // lstStaticQueue
            // 
            lstStaticQueue.Font = new Font("Swis721 Lt BT", 14.25F);
            lstStaticQueue.FormattingEnabled = true;
            lstStaticQueue.ItemHeight = 22;
            lstStaticQueue.Location = new Point(400, 87);
            lstStaticQueue.Name = "lstStaticQueue";
            lstStaticQueue.Size = new Size(119, 268);
            lstStaticQueue.TabIndex = 16;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(btnGetRear);
            tabPage6.Controls.Add(btnDeleteRear);
            tabPage6.Controls.Add(btnInsertRear);
            tabPage6.Controls.Add(label13);
            tabPage6.Controls.Add(lstQueueDoubleList);
            tabPage6.Controls.Add(label15);
            tabPage6.Controls.Add(lstQueueDobleVector);
            tabPage6.Controls.Add(btnSizeDoubleQueue);
            tabPage6.Controls.Add(btnGetFront);
            tabPage6.Controls.Add(btnDeleteFront);
            tabPage6.Controls.Add(btnInsertFront);
            tabPage6.Controls.Add(label12);
            tabPage6.Controls.Add(txtQueueDoubleValue);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(903, 465);
            tabPage6.TabIndex = 1;
            tabPage6.Text = "Double";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnGetRear
            // 
            btnGetRear.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetRear.Location = new Point(188, 251);
            btnGetRear.Name = "btnGetRear";
            btnGetRear.Size = new Size(138, 42);
            btnGetRear.TabIndex = 42;
            btnGetRear.Text = "Get Rear";
            btnGetRear.UseVisualStyleBackColor = true;
            btnGetRear.Click += btnGetRear_Click;
            // 
            // btnDeleteRear
            // 
            btnDeleteRear.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteRear.Location = new Point(188, 184);
            btnDeleteRear.Name = "btnDeleteRear";
            btnDeleteRear.Size = new Size(138, 42);
            btnDeleteRear.TabIndex = 41;
            btnDeleteRear.Text = "Delete Rear";
            btnDeleteRear.UseVisualStyleBackColor = true;
            btnDeleteRear.Click += btnDeleteRear_Click;
            // 
            // btnInsertRear
            // 
            btnInsertRear.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertRear.Location = new Point(188, 120);
            btnInsertRear.Name = "btnInsertRear";
            btnInsertRear.Size = new Size(138, 42);
            btnInsertRear.TabIndex = 40;
            btnInsertRear.Text = "Insert Rear";
            btnInsertRear.UseVisualStyleBackColor = true;
            btnInsertRear.Click += btnInsertRear_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold);
            label13.Location = new Point(734, 62);
            label13.Name = "label13";
            label13.Size = new Size(97, 22);
            label13.TabIndex = 39;
            label13.Text = "With Lists";
            // 
            // lstQueueDoubleList
            // 
            lstQueueDoubleList.Font = new Font("Swis721 Lt BT", 14.25F);
            lstQueueDoubleList.FormattingEnabled = true;
            lstQueueDoubleList.ItemHeight = 22;
            lstQueueDoubleList.Location = new Point(725, 87);
            lstQueueDoubleList.Name = "lstQueueDoubleList";
            lstQueueDoubleList.Size = new Size(119, 268);
            lstQueueDoubleList.TabIndex = 38;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold);
            label15.Location = new Point(550, 62);
            label15.Name = "label15";
            label15.Size = new Size(124, 22);
            label15.TabIndex = 37;
            label15.Text = "With Vectors";
            // 
            // lstQueueDobleVector
            // 
            lstQueueDobleVector.Font = new Font("Swis721 Lt BT", 14.25F);
            lstQueueDobleVector.FormattingEnabled = true;
            lstQueueDobleVector.ItemHeight = 22;
            lstQueueDobleVector.Location = new Point(555, 87);
            lstQueueDobleVector.Name = "lstQueueDobleVector";
            lstQueueDobleVector.Size = new Size(119, 268);
            lstQueueDobleVector.TabIndex = 36;
            // 
            // btnSizeDoubleQueue
            // 
            btnSizeDoubleQueue.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSizeDoubleQueue.Location = new Point(128, 313);
            btnSizeDoubleQueue.Name = "btnSizeDoubleQueue";
            btnSizeDoubleQueue.Size = new Size(96, 42);
            btnSizeDoubleQueue.TabIndex = 35;
            btnSizeDoubleQueue.Text = "Size";
            btnSizeDoubleQueue.UseVisualStyleBackColor = true;
            btnSizeDoubleQueue.Click += btnSizeDoubleQueue_Click;
            // 
            // btnGetFront
            // 
            btnGetFront.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetFront.Location = new Point(27, 251);
            btnGetFront.Name = "btnGetFront";
            btnGetFront.Size = new Size(138, 42);
            btnGetFront.TabIndex = 34;
            btnGetFront.Text = "Get Front";
            btnGetFront.UseVisualStyleBackColor = true;
            btnGetFront.Click += btnGetFront_Click;
            // 
            // btnDeleteFront
            // 
            btnDeleteFront.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteFront.Location = new Point(27, 184);
            btnDeleteFront.Name = "btnDeleteFront";
            btnDeleteFront.Size = new Size(138, 42);
            btnDeleteFront.TabIndex = 33;
            btnDeleteFront.Text = "Delete Front";
            btnDeleteFront.UseVisualStyleBackColor = true;
            btnDeleteFront.Click += btnDeleteFront_Click;
            // 
            // btnInsertFront
            // 
            btnInsertFront.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertFront.Location = new Point(27, 120);
            btnInsertFront.Name = "btnInsertFront";
            btnInsertFront.Size = new Size(138, 42);
            btnInsertFront.TabIndex = 32;
            btnInsertFront.Text = "Insert Front";
            btnInsertFront.UseVisualStyleBackColor = true;
            btnInsertFront.Click += btnInsertFront_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(60, 47);
            label12.Name = "label12";
            label12.Size = new Size(66, 22);
            label12.TabIndex = 31;
            label12.Text = "Value:";
            // 
            // txtQueueDoubleValue
            // 
            txtQueueDoubleValue.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQueueDoubleValue.Location = new Point(32, 72);
            txtQueueDoubleValue.Name = "txtQueueDoubleValue";
            txtQueueDoubleValue.Size = new Size(119, 30);
            txtQueueDoubleValue.TabIndex = 30;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(label21);
            tabPage7.Controls.Add(txtPriorityQueueLevel);
            tabPage7.Controls.Add(btnPriorityQueueSize);
            tabPage7.Controls.Add(btnPeekPriorityQueue);
            tabPage7.Controls.Add(btnDequeuePriorityQueue);
            tabPage7.Controls.Add(btnEnqueuePriorityQueue);
            tabPage7.Controls.Add(label17);
            tabPage7.Controls.Add(lstPriorityQueueLL);
            tabPage7.Controls.Add(label18);
            tabPage7.Controls.Add(lstPriorityQueueLV);
            tabPage7.Controls.Add(label19);
            tabPage7.Controls.Add(lstPriorityQueueVL);
            tabPage7.Controls.Add(label20);
            tabPage7.Controls.Add(lstPriorityQueueVV);
            tabPage7.Controls.Add(label16);
            tabPage7.Controls.Add(txtQueuePriorityValue);
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(903, 465);
            tabPage7.TabIndex = 2;
            tabPage7.Text = "Priority";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(61, 129);
            label21.Name = "label21";
            label21.Size = new Size(64, 22);
            label21.TabIndex = 47;
            label21.Text = "Level:";
            // 
            // txtPriorityQueueLevel
            // 
            txtPriorityQueueLevel.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPriorityQueueLevel.Location = new Point(33, 154);
            txtPriorityQueueLevel.Name = "txtPriorityQueueLevel";
            txtPriorityQueueLevel.Size = new Size(119, 30);
            txtPriorityQueueLevel.TabIndex = 46;
            // 
            // btnPriorityQueueSize
            // 
            btnPriorityQueueSize.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPriorityQueueSize.Location = new Point(225, 273);
            btnPriorityQueueSize.Name = "btnPriorityQueueSize";
            btnPriorityQueueSize.Size = new Size(96, 42);
            btnPriorityQueueSize.TabIndex = 45;
            btnPriorityQueueSize.Text = "Size";
            btnPriorityQueueSize.UseVisualStyleBackColor = true;
            btnPriorityQueueSize.Click += btnPriorityQueueuSize_Click;
            // 
            // btnPeekPriorityQueue
            // 
            btnPeekPriorityQueue.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPeekPriorityQueue.Location = new Point(225, 209);
            btnPeekPriorityQueue.Name = "btnPeekPriorityQueue";
            btnPeekPriorityQueue.Size = new Size(96, 42);
            btnPeekPriorityQueue.TabIndex = 44;
            btnPeekPriorityQueue.Text = "Peek";
            btnPeekPriorityQueue.UseVisualStyleBackColor = true;
            btnPeekPriorityQueue.Click += btnPeekPriorityQueue_Click;
            // 
            // btnDequeuePriorityQueue
            // 
            btnDequeuePriorityQueue.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDequeuePriorityQueue.Location = new Point(225, 142);
            btnDequeuePriorityQueue.Name = "btnDequeuePriorityQueue";
            btnDequeuePriorityQueue.Size = new Size(96, 42);
            btnDequeuePriorityQueue.TabIndex = 43;
            btnDequeuePriorityQueue.Text = "Dequeue";
            btnDequeuePriorityQueue.UseVisualStyleBackColor = true;
            btnDequeuePriorityQueue.Click += btnDequeuePriorityQueue_Click;
            // 
            // btnEnqueuePriorityQueue
            // 
            btnEnqueuePriorityQueue.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnqueuePriorityQueue.Location = new Point(225, 78);
            btnEnqueuePriorityQueue.Name = "btnEnqueuePriorityQueue";
            btnEnqueuePriorityQueue.Size = new Size(96, 42);
            btnEnqueuePriorityQueue.TabIndex = 42;
            btnEnqueuePriorityQueue.Text = "Enqueue";
            btnEnqueuePriorityQueue.UseVisualStyleBackColor = true;
            btnEnqueuePriorityQueue.Click += btnEnqueuePriorityQueue_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold);
            label17.Location = new Point(644, 248);
            label17.Name = "label17";
            label17.Size = new Size(169, 22);
            label17.TabIndex = 41;
            label17.Text = "With Lists of Lists";
            // 
            // lstPriorityQueueLL
            // 
            lstPriorityQueueLL.Font = new Font("Swis721 Lt BT", 14.25F);
            lstPriorityQueueLL.FormattingEnabled = true;
            lstPriorityQueueLL.ItemHeight = 22;
            lstPriorityQueueLL.Location = new Point(680, 282);
            lstPriorityQueueLL.Name = "lstPriorityQueueLL";
            lstPriorityQueueLL.Size = new Size(116, 158);
            lstPriorityQueueLL.TabIndex = 40;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold);
            label18.Location = new Point(388, 248);
            label18.Name = "label18";
            label18.Size = new Size(196, 22);
            label18.TabIndex = 39;
            label18.Text = "With Lists of Vectors";
            // 
            // lstPriorityQueueLV
            // 
            lstPriorityQueueLV.Font = new Font("Swis721 Lt BT", 14.25F);
            lstPriorityQueueLV.FormattingEnabled = true;
            lstPriorityQueueLV.ItemHeight = 22;
            lstPriorityQueueLV.Location = new Point(433, 282);
            lstPriorityQueueLV.Name = "lstPriorityQueueLV";
            lstPriorityQueueLV.Size = new Size(116, 158);
            lstPriorityQueueLV.TabIndex = 38;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold);
            label19.Location = new Point(638, 25);
            label19.Name = "label19";
            label19.Size = new Size(196, 22);
            label19.TabIndex = 37;
            label19.Text = "With Vectors of Lists";
            // 
            // lstPriorityQueueVL
            // 
            lstPriorityQueueVL.Font = new Font("Swis721 Lt BT", 14.25F);
            lstPriorityQueueVL.FormattingEnabled = true;
            lstPriorityQueueVL.ItemHeight = 22;
            lstPriorityQueueVL.Location = new Point(680, 59);
            lstPriorityQueueVL.Name = "lstPriorityQueueVL";
            lstPriorityQueueVL.Size = new Size(116, 158);
            lstPriorityQueueVL.TabIndex = 36;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold);
            label20.Location = new Point(388, 25);
            label20.Name = "label20";
            label20.Size = new Size(223, 22);
            label20.TabIndex = 35;
            label20.Text = "With Vectors of Vectors";
            // 
            // lstPriorityQueueVV
            // 
            lstPriorityQueueVV.Font = new Font("Swis721 Lt BT", 14.25F);
            lstPriorityQueueVV.FormattingEnabled = true;
            lstPriorityQueueVV.ItemHeight = 22;
            lstPriorityQueueVV.Location = new Point(433, 59);
            lstPriorityQueueVV.Name = "lstPriorityQueueVV";
            lstPriorityQueueVV.Size = new Size(116, 158);
            lstPriorityQueueVV.TabIndex = 34;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(61, 34);
            label16.Name = "label16";
            label16.Size = new Size(66, 22);
            label16.TabIndex = 33;
            label16.Text = "Value:";
            // 
            // txtQueuePriorityValue
            // 
            txtQueuePriorityValue.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQueuePriorityValue.Location = new Point(33, 59);
            txtQueuePriorityValue.Name = "txtQueuePriorityValue";
            txtQueuePriorityValue.Size = new Size(119, 30);
            txtQueuePriorityValue.TabIndex = 32;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(910, 492);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Binary Tree";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label29);
            tabPage4.Controls.Add(label28);
            tabPage4.Controls.Add(label27);
            tabPage4.Controls.Add(label26);
            tabPage4.Controls.Add(label25);
            tabPage4.Controls.Add(label24);
            tabPage4.Controls.Add(label22);
            tabPage4.Controls.Add(label23);
            tabPage4.Controls.Add(btnRemoveAll);
            tabPage4.Controls.Add(btnShowDFSRecursive);
            tabPage4.Controls.Add(btnShowBFS);
            tabPage4.Controls.Add(btnRemoveNode);
            tabPage4.Controls.Add(txtStartNode);
            tabPage4.Controls.Add(btnShowDFS);
            tabPage4.Controls.Add(chkDirected);
            tabPage4.Controls.Add(txtWeight);
            tabPage4.Controls.Add(txtGraphRepresentation);
            tabPage4.Controls.Add(btnRemoveEdge);
            tabPage4.Controls.Add(btnAddEdge);
            tabPage4.Controls.Add(txtTo);
            tabPage4.Controls.Add(txtFrom);
            tabPage4.Controls.Add(txtNode);
            tabPage4.Controls.Add(btnAddNode);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(910, 492);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "Graphs";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Swis721 Lt BT", 15F, FontStyle.Bold);
            label29.Location = new Point(147, 349);
            label29.Name = "label29";
            label29.Size = new Size(109, 24);
            label29.TabIndex = 32;
            label29.Text = "Traversals";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Swis721 Lt BT", 15F, FontStyle.Bold);
            label28.Location = new Point(161, 146);
            label28.Name = "label28";
            label28.Size = new Size(72, 24);
            label28.TabIndex = 31;
            label28.Text = "Edges";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Swis721 Lt BT", 15F, FontStyle.Bold);
            label27.Location = new Point(171, 18);
            label27.Name = "label27";
            label27.Size = new Size(73, 24);
            label27.TabIndex = 30;
            label27.Text = "Nodes";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.Location = new Point(82, 388);
            label26.Name = "label26";
            label26.Size = new Size(98, 19);
            label26.TabIndex = 29;
            label26.Text = "Node Start:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(80, 257);
            label25.Name = "label25";
            label25.Size = new Size(68, 19);
            label25.TabIndex = 28;
            label25.Text = "Weight:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(67, 223);
            label24.Name = "label24";
            label24.Size = new Size(81, 19);
            label24.TabIndex = 27;
            label24.Text = "Node To:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(47, 185);
            label22.Name = "label22";
            label22.Size = new Size(101, 19);
            label22.TabIndex = 26;
            label22.Text = "Node From:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(49, 55);
            label23.Name = "label23";
            label23.Size = new Size(106, 19);
            label23.TabIndex = 25;
            label23.Text = "Node Name:";
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(lstAux);
            tabPage8.Controls.Add(lstNumbersSort);
            tabPage8.Controls.Add(cmbAlgoritms);
            tabPage8.Controls.Add(btnSort);
            tabPage8.Controls.Add(btnSetNumbers);
            tabPage8.Location = new Point(4, 24);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(910, 492);
            tabPage8.TabIndex = 5;
            tabPage8.Text = "Sorting Algorithms";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // lstNumbersSort
            // 
            lstNumbersSort.Font = new Font("Segoe UI", 14F);
            lstNumbersSort.FormattingEnabled = true;
            lstNumbersSort.ItemHeight = 25;
            lstNumbersSort.Location = new Point(24, 97);
            lstNumbersSort.Name = "lstNumbersSort";
            lstNumbersSort.Size = new Size(407, 354);
            lstNumbersSort.TabIndex = 26;
            // 
            // cmbAlgoritms
            // 
            cmbAlgoritms.FormattingEnabled = true;
            cmbAlgoritms.Location = new Point(24, 32);
            cmbAlgoritms.Name = "cmbAlgoritms";
            cmbAlgoritms.Size = new Size(180, 23);
            cmbAlgoritms.TabIndex = 25;
            // 
            // btnSort
            // 
            btnSort.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSort.Location = new Point(449, 20);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(180, 42);
            btnSort.TabIndex = 24;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnSetNumbers
            // 
            btnSetNumbers.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSetNumbers.Location = new Point(260, 20);
            btnSetNumbers.Name = "btnSetNumbers";
            btnSetNumbers.Size = new Size(171, 42);
            btnSetNumbers.TabIndex = 23;
            btnSetNumbers.Text = "Generate Numbers";
            btnSetNumbers.UseVisualStyleBackColor = true;
            btnSetNumbers.Click += btnSetNumbers_Click;
            // 
            // lstAux
            // 
            lstAux.Font = new Font("Segoe UI", 14F);
            lstAux.FormattingEnabled = true;
            lstAux.ItemHeight = 25;
            lstAux.Location = new Point(474, 97);
            lstAux.Name = "lstAux";
            lstAux.Size = new Size(407, 354);
            lstAux.TabIndex = 27;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 515);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            Lists.ResumeLayout(false);
            Lists.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Lists;
        private TabPage tabPage2;
        private ListBox lstSimpleLinkedList;
        private Label label3;
        private ListBox lstDoubleCircularList;
        private Label label4;
        private ListBox lstCircularList;
        private Label label2;
        private ListBox lstDoubleList;
        private Label label1;
        private Label label5;
        private TextBox txtValue;
        private Button btnCount;
        private Button btnContains;
        private Button btnRemove;
        private Button btnAdd;
        private Label label7;
        private ListBox lstDynamicStack;
        private Label label6;
        private ListBox lstStaticStack;
        private Label label8;
        private TextBox txtStackValue;
        private Button btnSize;
        private Button btnPeek;
        private Button btnPop;
        private Button btnPush;
        private TabPage tabPage1;
        private TabControl tabControl2;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage7;
        private Button btnSizeQueue;
        private Button btnPeekQueue;
        private Button btnDequeue;
        private Button btnEnqueue;
        private Label label9;
        private TextBox txtValueSimpleQueue;
        private Label label10;
        private ListBox lstDynamicQueue;
        private Label label11;
        private ListBox lstStaticQueue;
        private Label label14;
        private ListBox lstCircularQueue;
        private Button btnSizeDoubleQueue;
        private Button btnGetFront;
        private Button btnDeleteFront;
        private Button btnInsertFront;
        private Label label12;
        private TextBox txtQueueDoubleValue;
        private Label label13;
        private ListBox lstQueueDoubleList;
        private Label label15;
        private ListBox lstQueueDobleVector;
        private Button btnGetRear;
        private Button btnDeleteRear;
        private Button btnInsertRear;
        private Label label16;
        private TextBox txtQueuePriorityValue;
        private Label label17;
        private ListBox lstPriorityQueueLL;
        private Label label18;
        private ListBox lstPriorityQueueLV;
        private Label label19;
        private ListBox lstPriorityQueueVL;
        private Label label20;
        private ListBox lstPriorityQueueVV;
        private Button btnPriorityQueueSize;
        private Button btnPeekPriorityQueue;
        private Button btnDequeuePriorityQueue;
        private Button btnEnqueuePriorityQueue;
        private Label label21;
        private TextBox txtPriorityQueueLevel;

        //ESTOS SON LOS COMPONENTES DE LA VENTANA DE GRAFOS
        
        private Button btnAddNode;
        private TextBox txtNode;
        private TextBox txtFrom;
        private TextBox txtTo;
        private Button btnAddEdge;
        private Button btnRemoveEdge;
        private TextBox txtGraphRepresentation;
        private TextBox txtWeight;
        private CheckBox chkDirected;
        private Button btnShowDFS;
        private TextBox txtStartNode;
        private Button btnRemoveNode;
        private Button btnShowBFS;
        private Button btnShowDFSRecursive;
        private Button btnRemoveAll;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label22;
        private Label label23;
        private Label label28;
        private Label label27;
        private Label label29;
        private TabPage tabPage8;
        private Button btnSetNumbers;
        private ComboBox cmbAlgoritms;
        private Button btnSort;
        private ListBox lstNumbersSort;
        private ListBox lstAux;
    }
}
