namespace labaratornaya1
{
	internal class Student : Human
	{
		private List<Order> orders;
		private ushort course;
		public Student(string name, Data data, ushort course) : base(name, data)
		{
			this.course = course;
			orders = new List<Order>();
		}
		public void AddOrder(Order order)
		{
			orders.Add(order);
		}
	}
}
