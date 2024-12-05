using Final_Project_Data_Structure_and_Sorting_Algorithms.Classes.Lists;
using Final_Project_Data_Structure_and_Sorting_Algorithms.Classes.Nodes;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Threading.Tasks;
using Final_Project_Data_Structure_and_Sorting_Algorithms.Classes.Stacks;
using Final_Project_Data_Structure_and_Sorting_Algorithms.Classes.Queues;
using Final_Project_Data_Structure_and_Sorting_Algorithms.Classes.Graphs;
using static Final_Project_Data_Structure_and_Sorting_Algorithms.Classes.Queues.PriorityQueues;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms
{
    public partial class Form1 : Form
    {
        private LinkedList linkedList;
        private DoublyLinkedList doubleLinkedList;
        private CircularLinkedList circularLinkedList;
        private DoublyCircularLinkedList doubleCircularLinkedList;
        private StaticStack staticStack;
        private DynamicStack dynamicStack;
        private StaticQueue staticQueue;
        private DynamicQueue dynamicQueue;
        private CircularQueue circularQueue;
        private DoubleEndedStaticQueue doubleEndedStaticQueue;
        private DoubleEndedDynamicQueue doubleEndedDynamicQueue;
        private Graph graph;
        private int[] numbers;
        private VectorOfVectors_PQ<int> vectorOfVectorsPQ;
        private VectorOfLists_PQ<int> vectorOfListsPQ;
        private ListOfLists_PQ<int> listOfListsPQ;
        private ListOfVectors_PQ<int> listOfVectorsPQ;

        public Form1()
        {
            InitializeComponent();
            linkedList = new LinkedList();
            doubleLinkedList = new DoublyLinkedList();
            circularLinkedList = new CircularLinkedList();
            doubleCircularLinkedList = new DoublyCircularLinkedList();
            staticStack = new StaticStack();
            dynamicStack = new DynamicStack();
            staticQueue = new StaticQueue(5);
            dynamicQueue = new DynamicQueue();
            circularQueue = new CircularQueue(5);
            doubleEndedStaticQueue = new DoubleEndedStaticQueue(5);
            doubleEndedDynamicQueue = new DoubleEndedDynamicQueue();
            graph = new Graph();
            cmbAlgoritms.Items.AddRange(new string[] { "Gnome Sort", "Heap Sort", "Bubble Sort", "Cocktail Sort", "Insertion Sort", "Shell Sort", "Selection Sort", "Quick Sort", "Merge Sort", "Comb Sort", "Counting Sort", "Bucket Sort" });
            cmbAlgoritms.SelectedIndex = 0;
            numbers = new int[] { };
            vectorOfVectorsPQ = new VectorOfVectors_PQ<int>(3);
            vectorOfListsPQ = new VectorOfLists_PQ<int>(3);
            listOfListsPQ = new ListOfLists_PQ<int>(3);
            listOfVectorsPQ = new ListOfVectors_PQ<int>(3);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Verificar si el valor ingresado es un número
            if (int.TryParse(txtValue.Text, out int value))
            {
                // Crear un nuevo nodo con el valor ingresado
                Node newNode = new Node(value);
                DoubleNode newDoubleNode = new DoubleNode(value);

                //Agregar el nodo a todas las listas
                linkedList.Add(newNode);
                circularLinkedList.Add(new Node(value));
                doubleLinkedList.Add(newDoubleNode);
                doubleCircularLinkedList.Add(new DoubleNode(value));

                // Limpiar los ListBox
                lstSimpleLinkedList.Items.Clear();
                lstDoubleList.Items.Clear();
                lstCircularList.Items.Clear();
                lstDoubleCircularList.Items.Clear();

                // Mostrar los valores en los ListBox para cada lista
                ShowListValues(lstSimpleLinkedList, linkedList.GetHead());
                ShowListValues(lstDoubleList, doubleLinkedList.GetHead());
                ShowListValues(lstCircularList, circularLinkedList.GetHead());
                ShowListValues(lstDoubleCircularList, doubleCircularLinkedList.GetHead());

                // Limpiar el TextBox después de agregar el nodo
                txtValue.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric value.");
            }
        }

        private void ShowListValues(ListBox listBox, object head)
        {
            listBox.Items.Clear(); // Limpiar la lista antes de mostrar valores

            if (head is Node headNode)
            {
                // Lista simple o lista simple circular
                Node current = headNode;

                do
                {
                    listBox.Items.Add(current.Value);
                    current = current.Next;
                } while (current != null && current != headNode); // Para manejar tanto listas simples como circulares
            }
            else if (head is DoubleNode headDoubleNode)
            {
                // Lista doble o lista doble circular
                DoubleNode current = headDoubleNode;

                do
                {
                    listBox.Items.Add(current.Value);
                    current = current.Next;
                } while (current != null && current != headDoubleNode);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValue.Text, out int value))
            {
                linkedList.Remove(value);
                doubleLinkedList.Remove(value);
                circularLinkedList.Remove(value);
                doubleCircularLinkedList.Remove(value);

                // Actualizar los ListBox
                ShowListValues(lstSimpleLinkedList, linkedList.GetHead());
                ShowListValues(lstDoubleList, doubleLinkedList.GetHead());
                ShowListValues(lstCircularList, circularLinkedList.GetHead());
                ShowListValues(lstDoubleCircularList, doubleCircularLinkedList.GetHead());

                txtValue.Clear(); // Limpiar el TextBox
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric value.");
            }
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValue.Text, out int value))
            {
                bool inSimpleList = linkedList.Contains(value);
                bool inDoubleList = doubleLinkedList.Contains(value);
                bool inCircularList = circularLinkedList.Contains(value);
                bool inDoubleCircularList = doubleCircularLinkedList.Contains(value);

                string message = $"Value {value} found in:\n" +
                                 $"- Simple Linked List: {inSimpleList}\n" +
                                 $"- Double Linked List: {inDoubleList}\n" +
                                 $"- Circular Linked List: {inCircularList}\n" +
                                 $"- Double Circular Linked List: {inDoubleCircularList}";

                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric value.");
            }

            txtValue.Clear();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int countSimple = linkedList.Count();
            int countDouble = doubleLinkedList.Count();
            int countCircular = circularLinkedList.Count();
            int countDoubleCircular = doubleCircularLinkedList.Count();

            // Mostrar los resultados en un MessageBox
            string message = $"Number of nodes in each list:\n" +
                             $"- Simple Linked List: {countSimple}\n" +
                             $"- Double Linked List: {countDouble}\n" +
                             $"- Circular Linked List: {countCircular}\n" +
                             $"- Double Circular Linked List: {countDoubleCircular}";

            MessageBox.Show(message);
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            // Verificar si el valor ingresado es un número
            if (int.TryParse(txtStackValue.Text, out int value))
            {
                Node newNode = new Node(Convert.ToInt32(txtStackValue.Text));
                // Agregar el valor a ambas pilas
                staticStack.Push(value);
                dynamicStack.Push(newNode);
                UpdateStacks();

                // Limpiar el TextBox después de agregar el valor
                txtStackValue.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un valor numérico válido.");
            }
        }

        private void UpdateStacks()
        {
            // Limpiar las listas antes de actualizar
            lstDynamicStack.Items.Clear();
            lstStaticStack.Items.Clear();

            // Actualizar la pila dinámica
            Node currentNode = dynamicStack.Peek();
            while (currentNode != null)
            {
                lstDynamicStack.Items.Add(currentNode.Value);
                currentNode = currentNode.Next;
            }

            // Actualizar la pila estática
            StaticStack temporal = new StaticStack();
            string elemento;

            // Mostrar los elementos en la pila estática
            while (!staticStack.IsEmpty())
            {
                elemento = staticStack.Pop().ToString();
                lstStaticStack.Items.Add(elemento);
                temporal.Push(int.Parse(elemento));
            }

            // Restaurar los elementos en la pila original
            while (!temporal.IsEmpty())
            {
                staticStack.Push(int.Parse(temporal.Pop().ToString()));
            }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (!dynamicStack.IsEmpty())
            {
                Node poppedNode = dynamicStack.Pop();
                MessageBox.Show("Element removed from the dynamic stack: " + poppedNode.Value + "\nElement removed from the static stack: " + staticStack.Pop());
                UpdateStacks();
                return;
            }
            if (dynamicStack.IsEmpty() && staticStack.IsEmpty())
            {
                MessageBox.Show("Both stacks are empty");
            }

        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            Node topNode = dynamicStack.Peek();
            if (!dynamicStack.IsEmpty() || !staticStack.IsEmpty())
            {
                MessageBox.Show("Element on the top of the dynamic stack is: " + topNode.Value + "\nElement on the top of the static stack is: " + staticStack.Peek());
                return;
            }
            MessageBox.Show("Both stacks are empty");
            return;
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Current static stack size is : " + staticStack.Size() + "\nCurrent dynamic stack size is: " + dynamicStack.Size());
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtValueSimpleQueue.Text, out int value))
                {
                    // Agregar valor a la cola estática
                    if (!staticQueue.IsFull())
                    {
                        staticQueue.Enqueue(value);
                        UpdateQueueDisplay(staticQueue, lstStaticQueue);
                    }
                    else
                    {
                        MessageBox.Show("Static queue is full.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Agregar valor a la cola dinámica
                    dynamicQueue.Enqueue(value);
                    UpdateQueueDisplay(dynamicQueue, lstDynamicQueue);

                    // Agregar valor a la cola circular
                    if (!circularQueue.IsFull())
                    {
                        circularQueue.Enqueue(value);
                        UpdateQueueDisplay(circularQueue, lstCircularQueue); // Actualiza la visualización de la cola circular
                    }
                    else
                    {
                        MessageBox.Show("Circular queue is full.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtValueSimpleQueue.Clear(); // Limpiar el TextBox después de insertar
                txtValueSimpleQueue.Focus(); // Colocar el cursor nuevamente en el TextBox
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateQueueDisplay(object queue, ListBox listBox)
        {
            listBox.Items.Clear();

            if (queue is StaticQueue staticQueue)
            {
                StaticQueue tempQueue = new StaticQueue(staticQueue.Capacity);

                while (!staticQueue.IsEmpty())
                {
                    int value = staticQueue.Dequeue();
                    listBox.Items.Add(value);
                    tempQueue.Enqueue(value);
                }

                // Restaurar los elementos a la cola estática
                while (!tempQueue.IsEmpty())
                {
                    staticQueue.Enqueue(tempQueue.Dequeue());
                }
            }
            else if (queue is DynamicQueue dynamicQueue)
            {
                DynamicQueue tempQueue = new DynamicQueue();

                while (!dynamicQueue.IsEmpty())
                {
                    int value = dynamicQueue.Dequeue();
                    listBox.Items.Add(value);
                    tempQueue.Enqueue(value);
                }

                // Restaurar los elementos a la cola dinámica
                while (!tempQueue.IsEmpty())
                {
                    dynamicQueue.Enqueue(tempQueue.Dequeue());
                }
            }
            else if (queue is CircularQueue circularQueue)
            {
                CircularQueue tempQueue = new CircularQueue(circularQueue.Capacity);

                while (!circularQueue.IsEmpty())
                {
                    int value = circularQueue.Dequeue();
                    listBox.Items.Add(value);
                    tempQueue.Enqueue(value);
                }

                // Restaurar los elementos a la cola circular
                while (!tempQueue.IsEmpty())
                {
                    circularQueue.Enqueue(tempQueue.Dequeue());
                }
            }
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder message = new StringBuilder();

                // Eliminar un valor de la cola estática
                if (!staticQueue.IsEmpty())
                {
                    int dequeuedValueStatic = staticQueue.Dequeue();
                    UpdateQueueDisplay(staticQueue, lstStaticQueue);
                    message.AppendLine($"Static Queue: {dequeuedValueStatic}");
                }
                else
                {
                    message.AppendLine("Static Queue: Empty");
                }

                // Eliminar un valor de la cola dinámica
                if (!dynamicQueue.IsEmpty())
                {
                    int dequeuedValueDynamic = dynamicQueue.Dequeue();
                    UpdateQueueDisplay(dynamicQueue, lstDynamicQueue);
                    message.AppendLine($"Dynamic Queue: {dequeuedValueDynamic}");
                }
                else
                {
                    message.AppendLine("Dynamic Queue: Empty");
                }

                // Eliminar un valor de la cola circular
                if (!circularQueue.IsEmpty())
                {
                    int dequeuedValueCircular = circularQueue.Dequeue();
                    UpdateQueueDisplay(circularQueue, lstCircularQueue);
                    message.AppendLine($"Circular Queue: {dequeuedValueCircular}");
                }
                else
                {
                    message.AppendLine("Circular Queue: Empty");
                }

                // Mostrar todos los resultados en un solo MessageBox
                MessageBox.Show(message.ToString(), "Dequeued Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPeekQueue_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder message = new StringBuilder();

                // Ver el valor al frente de la cola estática sin eliminarlo
                if (!staticQueue.IsEmpty())
                {
                    int frontValueStatic = staticQueue.Peek();
                    message.AppendLine($"Static Queue: {frontValueStatic}");
                }
                else
                {
                    message.AppendLine("Static Queue: Empty");
                }

                // Ver el valor al frente de la cola dinámica sin eliminarlo
                if (!dynamicQueue.IsEmpty())
                {
                    int frontValueDynamic = dynamicQueue.Peek();
                    message.AppendLine($"Dynamic Queue: {frontValueDynamic}");
                }
                else
                {
                    message.AppendLine("Dynamic Queue: Empty");
                }

                // Ver el valor al frente de la cola circular sin eliminarlo
                if (!circularQueue.IsEmpty())
                {
                    int frontValueCircular = circularQueue.Peek();
                    message.AppendLine($"Circular Queue: {frontValueCircular}");
                }
                else
                {
                    message.AppendLine("Circular Queue: Empty");
                }

                // Mostrar todos los resultados en un solo MessageBox
                MessageBox.Show(message.ToString(), "Peek Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSizeQueue_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder message = new StringBuilder();

                // Obtener el tamaño de la cola estática
                int staticQueueSize = staticQueue.Size();
                message.AppendLine($"Static Queue Size: {staticQueueSize}");

                // Obtener el tamaño de la cola dinámica
                int dynamicQueueSize = dynamicQueue.Size();
                message.AppendLine($"Dynamic Queue Size: {dynamicQueueSize}");

                // Obtener el tamaño de la cola circular
                int circularQueueSize = circularQueue.Size();
                message.AppendLine($"Circular Queue Size: {circularQueueSize}");

                // Mostrar todos los tamaños en un solo MessageBox
                MessageBox.Show(message.ToString(), "Queue Sizes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertFront_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtQueueDoubleValue.Text, out int value))
                {
                    // Insertar al frente de la cola estática
                    if (!doubleEndedStaticQueue.IsFull())
                    {
                        doubleEndedStaticQueue.InsertFront(value); // Insertar al final de la cola estática

                        // Limpiar y actualizar el ListBox para la cola estática
                        lstQueueDobleVector.Items.Clear();
                        foreach (var item in doubleEndedStaticQueue.GetQueueElements()) // Obtener elementos de la cola estática
                        {
                            lstQueueDobleVector.Items.Add(item);  // Agregar cada elemento al ListBox de la cola estática
                        }
                    }
                    else
                    {
                        // Manejar el error si la cola estática está llena
                        MessageBox.Show("Static double queue is full", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    // Insertar al frente de la cola dinámica (sin depender de la cola estática)
                    try
                    {
                        doubleEndedDynamicQueue.InsertFront(value); // Inserta el valor al frente de la cola dinámica

                        // Limpiar y actualizar el ListBox para la cola dinámica
                        lstQueueDoubleList.Items.Clear();
                        foreach (var item in doubleEndedDynamicQueue.GetQueueElements())
                        {
                            lstQueueDoubleList.Items.Add(item);  // Agregar cada elemento al ListBox de la cola dinámica
                        }
                    }
                    catch (InvalidOperationException ex)
                    {
                        // Manejar el error si la cola dinámica está llena
                        MessageBox.Show($"Dynamic queue error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Limpiar el TextBox y dar foco de nuevo
                txtQueueDoubleValue.Clear();
                txtQueueDoubleValue.Focus();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones genéricas
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertRear_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si la entrada es un número
                if (int.TryParse(txtQueueDoubleValue.Text, out int value))
                {
                    // Insertar en la cola estática
                    if (!doubleEndedStaticQueue.IsFull())
                    {
                        doubleEndedStaticQueue.InsertRear(value); // Insertar al final de la cola estática

                        // Limpiar y actualizar el ListBox para la cola estática
                        lstQueueDobleVector.Items.Clear();
                        foreach (var item in doubleEndedStaticQueue.GetQueueElements()) // Obtener elementos de la cola estática
                        {
                            lstQueueDobleVector.Items.Add(item);  // Agregar cada elemento al ListBox de la cola estática
                        }
                    }
                    else
                    {
                        // Manejar el error si la cola estática está llena
                        MessageBox.Show("Static double queue is full", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Insertar en la cola dinámica
                    try
                    {
                        doubleEndedDynamicQueue.InsertRear(value); // Insertar al final de la cola dinámica

                        // Limpiar y actualizar el ListBox para la cola dinámica
                        lstQueueDoubleList.Items.Clear();
                        foreach (var item in doubleEndedDynamicQueue.GetQueueElements()) // Obtener elementos de la cola dinámica
                        {
                            lstQueueDoubleList.Items.Add(item);  // Agregar cada elemento al ListBox de la cola dinámica
                        }
                    }
                    catch (InvalidOperationException ex)
                    {
                        // Manejar el error si la cola dinámica está llena
                        MessageBox.Show($"Dynamic queue error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Si la entrada no es un número, mostrar mensaje de error
                    MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Limpiar el TextBox y dar foco de nuevo
                txtQueueDoubleValue.Clear();
                txtQueueDoubleValue.Focus();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones genéricas
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteFront_Click(object sender, EventArgs e)
        {
            try
            {
                // Intentar eliminar el elemento desde el frente de la cola estática
                try
                {
                    if (!doubleEndedStaticQueue.IsEmpty()) // Verificar si la cola estática no está vacía
                    {
                        doubleEndedStaticQueue.DeleteFront(); // Eliminar desde el frente de la cola estática

                        // Limpiar y actualizar el ListBox para la cola estática
                        lstQueueDobleVector.Items.Clear();
                        foreach (var item in doubleEndedStaticQueue.GetQueueElements()) // Obtener elementos de la cola estática
                        {
                            lstQueueDobleVector.Items.Add(item);  // Agregar cada elemento al ListBox de la cola estática
                        }
                    }
                    else
                    {
                        MessageBox.Show("Static queue is empty, cannot delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error de la cola estática
                    MessageBox.Show($"Static queue error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Intentar eliminar el elemento desde el frente de la cola dinámica
                try
                {
                    if (!doubleEndedDynamicQueue.IsEmpty()) // Verificar si la cola dinámica no está vacía
                    {
                        doubleEndedDynamicQueue.DeleteFront(); // Eliminar desde el frente de la cola dinámica

                        // Limpiar y actualizar el ListBox para la cola dinámica
                        lstQueueDoubleList.Items.Clear();
                        foreach (var item in doubleEndedDynamicQueue.GetQueueElements()) // Obtener elementos de la cola dinámica
                        {
                            lstQueueDoubleList.Items.Add(item);  // Agregar cada elemento al ListBox de la cola dinámica
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dynamic queue is empty, cannot delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error de la cola dinámica
                    MessageBox.Show($"Dynamic queue error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                // Manejo de excepciones genéricas
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteRear_Click(object sender, EventArgs e)
        {
            try
            {
                // Intentar eliminar el elemento desde el final de la cola estática
                try
                {
                    if (!doubleEndedStaticQueue.IsEmpty()) // Verificar si la cola estática no está vacía
                    {
                        doubleEndedStaticQueue.DeleteRear(); // Eliminar desde el final de la cola estática

                        // Limpiar y actualizar el ListBox para la cola estática
                        lstQueueDobleVector.Items.Clear();
                        foreach (var item in doubleEndedStaticQueue.GetQueueElements()) // Obtener elementos de la cola estática
                        {
                            lstQueueDobleVector.Items.Add(item);  // Agregar cada elemento al ListBox de la cola estática
                        }
                    }
                    else
                    {
                        MessageBox.Show("Static queue is empty, cannot delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error de la cola estática
                    MessageBox.Show($"Static queue error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Intentar eliminar el elemento desde el final de la cola dinámica
                try
                {
                    if (!doubleEndedDynamicQueue.IsEmpty()) // Verificar si la cola dinámica no está vacía
                    {
                        doubleEndedDynamicQueue.DeleteRear(); // Eliminar desde el final de la cola dinámica

                        // Limpiar y actualizar el ListBox para la cola dinámica
                        lstQueueDoubleList.Items.Clear();
                        foreach (var item in doubleEndedDynamicQueue.GetQueueElements()) // Obtener elementos de la cola dinámica
                        {
                            lstQueueDoubleList.Items.Add(item);  // Agregar cada elemento al ListBox de la cola dinámica
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dynamic queue is empty, cannot delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error de la cola dinámica
                    MessageBox.Show($"Dynamic queue error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                // Manejo de excepciones genéricas
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetFront_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el primer elemento de la cola estática
                try
                {
                    if (!doubleEndedStaticQueue.IsEmpty()) // Verificar si la cola estática no está vacía
                    {
                        int frontStatic = doubleEndedStaticQueue.GetFront(); // Obtener el primer elemento de la cola estática
                        MessageBox.Show($"Front of static queue: {frontStatic}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Static queue is empty, cannot get front.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error de la cola estática
                    MessageBox.Show($"Static queue error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Obtener el primer elemento de la cola dinámica
                try
                {
                    if (!doubleEndedDynamicQueue.IsEmpty()) // Verificar si la cola dinámica no está vacía
                    {
                        int frontDynamic = doubleEndedDynamicQueue.GetFront(); // Obtener el primer elemento de la cola dinámica
                        MessageBox.Show($"Front of dynamic queue: {frontDynamic}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Dynamic queue is empty, cannot get front.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error de la cola dinámica
                    MessageBox.Show($"Dynamic queue error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones genéricas
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetRear_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el último elemento de la cola estática
                try
                {
                    if (!doubleEndedStaticQueue.IsEmpty()) // Verificar si la cola estática no está vacía
                    {
                        int rearStatic = doubleEndedStaticQueue.GetRear(); // Obtener el último elemento de la cola estática
                        MessageBox.Show($"Rear of static queue: {rearStatic}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Static queue is empty, cannot get rear.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error de la cola estática
                    MessageBox.Show($"Static queue error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Obtener el último elemento de la cola dinámica
                try
                {
                    if (!doubleEndedDynamicQueue.IsEmpty()) // Verificar si la cola dinámica no está vacía
                    {
                        int rearDynamic = doubleEndedDynamicQueue.GetRear(); // Obtener el último elemento de la cola dinámica
                        MessageBox.Show($"Rear of dynamic queue: {rearDynamic}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Dynamic queue is empty, cannot get rear.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error de la cola dinámica
                    MessageBox.Show($"Dynamic queue error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones genéricas
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSizeDoubleQueue_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el tamaño de la cola estática
                int staticQueueSize = doubleEndedStaticQueue.Size(); // Obtener el tamaño de la cola estática
                MessageBox.Show($"Size of static queue: {staticQueueSize}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Obtener el tamaño de la cola dinámica
                int dynamicQueueSize = doubleEndedDynamicQueue.Size(); // Obtener el tamaño de la cola dinámica
                MessageBox.Show($"Size of dynamic queue: {dynamicQueueSize}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Capturar y mostrar errores
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //FALTA COLAS DE PRIORIDAD
        private void btnEnqueuePriorityQueue_Click(object sender, EventArgs e)
        {
            try
            {
                // Intentamos convertir los valores del texto a enteros
                if (int.TryParse(txtQueuePriorityValue.Text, out int value))
                {
                    // Convertimos el nivel de prioridad
                    int priority = Convert.ToInt16(txtPriorityQueueLevel.Text);

                    // Encolamos los valores en las diferentes estructuras de datos
                    vectorOfVectorsPQ.Enqueue(value, priority);
                    vectorOfListsPQ.Enqueue(value, priority);
                    listOfListsPQ.Enqueue(value, priority);
                    listOfVectorsPQ.Enqueue(value, priority);
                    UpdateListBoxes();
                }
            }
            catch (FormatException ex)
            {
                // Capturamos el error si la conversión del nivel de prioridad falla
                MessageBox.Show($"Invalid format for priority level. Please enter a valid integer. Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Capturamos cualquier otro error general
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void UpdateListBoxes()
        {
            lstPriorityQueueVV.Items.Clear();
            lstPriorityQueueVL.Items.Clear();
            lstPriorityQueueLV.Items.Clear();
            lstPriorityQueueLL.Items.Clear();

            UpdateListBox(lstPriorityQueueVV, vectorOfVectorsPQ);
            UpdateListBox(lstPriorityQueueVL, vectorOfListsPQ);
            UpdateListBox(lstPriorityQueueLL, listOfListsPQ);
            UpdateListBox(lstPriorityQueueLV, listOfVectorsPQ);
        }

        private void UpdateListBox<T>(ListBox listBox, T queue) where T : class
        {
            listBox.Items.Clear();
            var items = (queue as dynamic).ToList();
            listBox.Items.AddRange(items.ToArray());
        }

        private void btnDequeuePriorityQueue_Click(object sender, EventArgs e)
        {
            try
            {
                if (!vectorOfVectorsPQ.IsEmpty())
                {
                    var dequeuedItem = vectorOfVectorsPQ.Dequeue();
                    MessageBox.Show($"Dequeued from vectorOfVectorsPQ: {dequeuedItem}");
                }
                else
                {
                    MessageBox.Show("vectorOfVectorsPQ is empty.");
                }

                if (!vectorOfListsPQ.IsEmpty())
                {
                    var dequeuedItem = vectorOfListsPQ.Dequeue();
                    MessageBox.Show($"Dequeued from vectorOfListsPQ: {dequeuedItem}");
                }
                else
                {
                    MessageBox.Show("vectorOfListsPQ is empty.");
                }

                if (!listOfListsPQ.IsEmpty())
                {
                    var dequeuedItem = listOfListsPQ.Dequeue();
                    MessageBox.Show($"Dequeued from listOfListsPQ: {dequeuedItem}");
                }
                else
                {
                    MessageBox.Show("listOfListsPQ is empty.");
                }

                if (!listOfVectorsPQ.IsEmpty())
                {
                    var dequeuedItem = listOfVectorsPQ.Dequeue();
                    MessageBox.Show($"Dequeued from listOfVectorsPQ: {dequeuedItem}");
                }
                else
                {
                    MessageBox.Show("listOfVectorsPQ is empty.");
                }

                // Actualizamos los ListBoxes después de realizar el dequeue
                UpdateListBoxes();
            }
            catch (Exception ex)
            {
                // Si ocurre algún error inesperado, lo mostramos al usuario
                MessageBox.Show($"An error occurred while dequeuing: {ex.Message}");
            }
        }

        private void btnPeekPriorityQueue_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificamos si las colas tienen elementos antes de hacer un Peek
                if (!vectorOfVectorsPQ.IsEmpty())
                {
                    var peekedItem = vectorOfVectorsPQ.Peek();
                    MessageBox.Show($"Next item in vectorOfVectorsPQ: {peekedItem}");
                }
                else
                {
                    MessageBox.Show("vectorOfVectorsPQ is empty.");
                }

                if (!vectorOfListsPQ.IsEmpty())
                {
                    var peekedItem = vectorOfListsPQ.Peek();
                    MessageBox.Show($"Next item in vectorOfListsPQ: {peekedItem}");
                }
                else
                {
                    MessageBox.Show("vectorOfListsPQ is empty.");
                }

                if (!listOfListsPQ.IsEmpty())
                {
                    var peekedItem = listOfListsPQ.Peek();
                    MessageBox.Show($"Next item in listOfListsPQ: {peekedItem}");
                }
                else
                {
                    MessageBox.Show("listOfListsPQ is empty.");
                }

                if (!listOfVectorsPQ.IsEmpty())
                {
                    var peekedItem = listOfVectorsPQ.Peek();
                    MessageBox.Show($"Next item in listOfVectorsPQ: {peekedItem}");
                }
                else
                {
                    MessageBox.Show("listOfVectorsPQ is empty.");
                }
            }
            catch (Exception ex)
            {
                // Si ocurre algún error inesperado, lo mostramos al usuario
                MessageBox.Show($"An error occurred while peeking: {ex.Message}");
            }
        }
        //FALTA COLAS DE PIRORIDAD
        private void btnAddNode_Click(object sender, EventArgs e)
        {
            string nodeName = txtNode.Text.Trim();
            if (!string.IsNullOrEmpty(nodeName))
            {
                // Verificar si el nodo ya existe en el grafo
                if (graph.Nodes.Any(node => node.Name == nodeName))
                {
                    MessageBox.Show($"The node '{nodeName}' already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    // Si no existe, añadir el nodo
                    GraphNode newNode = new GraphNode(nodeName);
                    graph.AddNode(newNode);
                    MessageBox.Show($"Node '{nodeName}' added.", "Success", MessageBoxButtons.OK);
                    txtNode.Clear();
                    string weightText = txtWeight.Text.Trim();
                    if (!string.IsNullOrEmpty(weightText) && int.TryParse(weightText, out int weight))
                    {
                        txtGraphRepresentation.Text = graph.ShowAdjacencyListWithWeights();
                    }
                    else
                    {
                        txtGraphRepresentation.Text = graph.ShowAdjacencyList();
                    }
                    txtFrom.Clear();
                    txtTo.Clear();
                }
            }
        }

        private void btnAddEdge_Click(object sender, EventArgs e)
        {
            string fromNodeName = txtFrom.Text.Trim();
            string toNodeName = txtTo.Text.Trim();
            string weightText = txtWeight.Text.Trim(); // Asumimos que tienes un campo de texto para el peso

            GraphNode fromNode = graph.Nodes.Find(n => n.Name == fromNodeName);
            GraphNode toNode = graph.Nodes.Find(n => n.Name == toNodeName);

            if (fromNode != null && toNode != null)
            {
                // Si el campo de peso no está vacío, se usa el constructor con peso
                if (!string.IsNullOrEmpty(weightText) && int.TryParse(weightText, out int weight))
                {
                    if (chkDirected.Checked)
                    {
                        graph.AddEdge(fromNode, toNode, weight);
                        MessageBox.Show($"Edge added from '{fromNodeName}' to '{toNodeName}' with weight {weight}.");
                    }
                    else
                    {
                        graph.AddNoDirectedEdge(fromNode, toNode, weight);
                        MessageBox.Show($"Edge added from '{fromNodeName}' to '{toNodeName}' with weight {weight}.");
                    }
                    txtGraphRepresentation.Text = graph.ShowAdjacencyListWithWeights();
                }
                else
                {
                    // Si no se especifica peso, se usa el constructor sin peso
                    if (chkDirected.Checked)
                    {
                        graph.AddEdge(fromNode, toNode);
                        MessageBox.Show($"Edge added from '{fromNodeName}' to '{toNodeName}'.");
                    }
                    else
                    {
                        graph.AddNoDirectedEdge(fromNode, toNode);
                        MessageBox.Show($"Edge added from '{fromNodeName}' to '{toNodeName}'.");
                    }
                    txtGraphRepresentation.Text = graph.ShowAdjacencyList();
                }
                txtFrom.Clear();
                txtTo.Clear();
            }
            else
            {
                MessageBox.Show("One or both nodes do not exist.");
            }
        }

        private void btnRemoveNode_Click(object sender, EventArgs e)
        {
            string nodeName = txtNode.Text.Trim();
            GraphNode nodeToRemove = graph.Nodes.Find(n => n.Name == nodeName);

            if (nodeToRemove != null)
            {
                graph.RemoveNode(nodeToRemove);
                MessageBox.Show($"Node '{nodeName}' deleted.", "Success", MessageBoxButtons.OK);
                txtNode.Clear();

                // Actualizar la representación de la lista de adyacencia
                string weightText = txtWeight.Text.Trim();
                if (!string.IsNullOrEmpty(weightText) && int.TryParse(weightText, out int weight))
                {
                    txtGraphRepresentation.Text = graph.ShowAdjacencyListWithWeights();
                }
                else
                {
                    txtGraphRepresentation.Text = graph.ShowAdjacencyList();
                }
                txtFrom.Clear();
                txtTo.Clear();
            }
            else
            {
                MessageBox.Show("Node not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveEdge_Click(object sender, EventArgs e)
        {
            string fromNodeName = txtFrom.Text.Trim();
            string toNodeName = txtTo.Text.Trim();
            bool isDirected = chkDirected.Checked; // CheckBox para determinar si la arista es dirigida.

            GraphNode fromNode = graph.Nodes.Find(n => n.Name == fromNodeName);
            GraphNode toNode = graph.Nodes.Find(n => n.Name == toNodeName);

            if (fromNode != null && toNode != null)
            {
                if (isDirected)
                {
                    graph.RemoveEdge(fromNode, toNode);
                    MessageBox.Show($"Directed edge removed from '{fromNodeName}' to '{toNodeName}'.", "Success", MessageBoxButtons.OK);
                }
                else
                {
                    graph.RemoveEdge(fromNode, toNode);
                    graph.RemoveEdge(toNode, fromNode);
                    MessageBox.Show($"Undirected edge removed between '{fromNodeName}' and '{toNodeName}'.", "Success", MessageBoxButtons.OK);
                }

                string weightText = txtWeight.Text.Trim();
                if (!string.IsNullOrEmpty(weightText) && int.TryParse(weightText, out int weight))
                {
                    txtGraphRepresentation.Text = graph.ShowAdjacencyListWithWeights();
                }
                else
                {
                    txtGraphRepresentation.Text = graph.ShowAdjacencyList();
                }

                txtFrom.Clear();
                txtTo.Clear();
            }
            else
            {
                MessageBox.Show("One or both nodes do not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnShowDFS_Click(object sender, EventArgs e)
        {
            txtGraphRepresentation.Clear();
            // Obtener el nombre del nodo de inicio desde una TextBox (puede ser un número o una palabra)
            string startNodeName = txtStartNode.Text;

            // Buscar el nodo en el grafo cuyo nombre coincida con el ingresado
            GraphNode startNode = graph.Nodes.FirstOrDefault(n => n.Name == startNodeName);

            if (startNode != null)
            {
                // Realizar DFS desde el nodo encontrado
                string result = graph.DFSIterative(startNode);
                txtGraphRepresentation.Text = result;  // Mostrar el resultado en el TextBox
            }
            else
            {
                // Si el nodo no existe, mostrar un mensaje de error
                txtGraphRepresentation.Text = "Node not found.";
            }
        }

        private void btnShowBFS_Click(object sender, EventArgs e)
        {
            txtGraphRepresentation.Clear();
            // Obtener el nombre del nodo de inicio desde una TextBox (puede ser un número o una palabra)
            string startNodeName = txtStartNode.Text;

            // Buscar el nodo en el grafo cuyo nombre coincida con el ingresado
            GraphNode startNode = graph.Nodes.FirstOrDefault(n => n.Name == startNodeName);

            if (startNode != null)
            {
                // Realizar DFS desde el nodo encontrado
                string result = graph.BFS(startNode);
                txtGraphRepresentation.Text = result;  // Mostrar el resultado en el TextBox
            }
            else
            {
                // Si el nodo no existe, mostrar un mensaje de error
                txtGraphRepresentation.Text = "Node not found.";
            }
        }

        private void btnShowDFSRecursive_Click(object sender, EventArgs e)
        {
            txtGraphRepresentation.Clear();
            // Obtener el nombre del nodo de inicio desde una TextBox (puede ser un número o una palabra)
            string startNodeName = txtStartNode.Text;
            GraphNode startNode = graph.Nodes.FirstOrDefault(n => n.Name == startNodeName);
            if (startNode != null)
            {
                string result = graph.DFS(startNode);
                txtGraphRepresentation.Text = result;
            }
            else
            {
                txtGraphRepresentation.Text = "Node not found.";
            }

        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            //add a validation in english
            DialogResult result = MessageBox.Show("Are you sure you want to remove all nodes and edges?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                graph.RemoveGraph();
                MessageBox.Show("All nodes and edges removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGraphRepresentation.Clear();

            }
        }

        private void btnSetNumbers_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            numbers = Enumerable.Range(0, 10).Select(_ => random.Next(1, 100)).ToArray();
            DisplayNumbers(numbers);
        }

        private async void btnSort_Click(object sender, EventArgs e)
        {
            if (numbers == null || numbers.Length == 0)
            {
                MessageBox.Show("Por favor, genera los números primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedMethod = cmbAlgoritms.SelectedItem.ToString();

            switch (selectedMethod)
            {
                case "Gnome Sort":
                    await GnomeSort.Sort(numbers, DisplayNumbers);
                    break;
                case "Bubble Sort":
                    await BubbleSort.Sort(numbers, DisplayNumbers);
                    break;
                case "Comb Sort":
                    await CombSort.Sort(numbers, DisplayNumbers);
                    break;
                case "Cocktail Sort":
                    await CocktailSort.Sort(numbers, DisplayNumbers);
                    break;
                case "Heap Sort":
                    await HeapSort.Sort(numbers, DisplayNumbers);
                    break;
                case "Insertion Sort":
                    await InsertionSort.Sort(numbers, DisplayNumbers);
                    break;
                case "Shell Sort":
                    await ShellSort.Sort(numbers, DisplayNumbers);
                    break;
                case "Selection Sort":
                    await SelectionSort.Sort(numbers, DisplayNumbers);
                    break;
                case "Counting Sort":
                    await SelectionSort.Sort(numbers, DisplayNumbers);
                    break;
                case "Merge Sort":
                    await MergeAlgorithms.MergeSort(numbers, 0, numbers.Length - 1, DisplayNumbers);
                    break;
                case "Quick Sort":
                    //CHECAR BIEN ESTA MADRE
                    await QuickSort.Sort(numbers, 0, numbers.Length - 1, DisplayNumbers);
                    break;
                default:
                    MessageBox.Show("Método de ordenamiento no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }



            MessageBox.Show("¡Ordenamiento completado!", selectedMethod, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DisplayNumbers(int[] array, int currentIndex = -1, int compareIndex = -1)
        {
            lstNumbersSort.Items.Clear();
            for (int i = 0; i < array.Length; i++)
            {
                string itemText = array[i].ToString();
                if (i == currentIndex || i == compareIndex)
                {
                    itemText = $"[{itemText}]";
                }
                lstNumbersSort.Items.Add(itemText);
            }
        }

        private void btnPriorityQueueuSize_Click(object sender, EventArgs e)
        {
            try
            {
                // Mostrar el tamaño de cada cola
                MessageBox.Show($"vectorOfVectorsPQ size: {vectorOfVectorsPQ.Size()}");
                MessageBox.Show($"vectorOfListsPQ size: {vectorOfListsPQ.Size()}");
                MessageBox.Show($"listOfListsPQ size: {listOfListsPQ.Size()}");
                MessageBox.Show($"listOfVectorsPQ size: {listOfVectorsPQ.Size()}");
            }
            catch (Exception ex)
            {
                // Manejar cualquier error inesperado
                MessageBox.Show($"An error occurred while retrieving the sizes: {ex.Message}");
            }
        }
    }
}
