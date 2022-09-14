namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option\n1.Create simple stack\n2.Peek pop stack\n3.Create Queue\n4.Dequeue operation");
            int option=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch(option)
            {
                case 1:
                    CreateStatck create = new CreateStatck();
                    create.Push(70);
                    create.Push(30);
                    create.Push(56);
                    create.Display();
                break;
                case 2:
                    PeekPop peekpop = new PeekPop();
                    peekpop.Push(70);
                    peekpop.Push(30);
                    peekpop.Push(56);
                    peekpop.IsEmpty();
                    peekpop.Display();
                    break;
                case 3:
                    CreateQueue createque = new CreateQueue();
                    createque.Enqueue(56);
                    createque.Enqueue(30);
                    createque.Enqueue(70);
                    createque.Display();
                    break;
                case 4:
                    QueueDequeue dequeue= new QueueDequeue();
                    dequeue.Enqueue(56);
                    dequeue.Enqueue(30);
                    dequeue.Enqueue(70);
                    dequeue.IsEmpty();
                    dequeue.Display();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                break;
             }
        }
    }
}