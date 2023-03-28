namespace laba1
{
	static class Query
	{
		public static IEnumerable<U> Map<T, U>(this IEnumerable<T> collect, Func<T, U> f)
		{
			// функція  Map повертає колекцію яка є результатом дії функції  f на вхідну колекцію collect
			var result = new List<U>();
			foreach (var item in collect)
			{
				result.Add(f(item));
			}
			return result;
		}

		public static IEnumerable<int> Filter(this IEnumerable<int> collect, Predicate<int> p)
		{
			// функція  Filter виконує фільтрацію послідовності (collect) значень на основі заданого предикату p
			var buffer = new List<int>();
			foreach (var item in collect)
			{
				if (p(item)) buffer.Add(item);
			}
			return buffer;
		}

		public static uint Numbers<T>(this IEnumerable<T> collect)
		{
			// функція  Numbers повертає кількість елементів колекції collect
			uint count = 0;
			foreach (var item in collect)
			{
				count++;
			}
			return count;
		}

		public static T[] ToMasiv<T>(this IEnumerable<T> collect)
		{
			var size = collect.Numbers();
			var array = new T[size];
			int it = 0;
			foreach (var item in collect)
			{
				array[it] = item;
				it++;
			}
			return array;
		}

		public static List<T> ToSpisok<T>(this IEnumerable<T> collect)
		{
			var size = collect.Numbers();
			var spisok = new List<T>();
			foreach (var item in collect)
			{
				spisok.Add(item);
			}
			return spisok;
		}

		public static IEnumerable<U> SortKey<U, V>(this IEnumerable<U> collect, Func<U, V> key) where V : IComparable<V>
		{
			uint length = collect.Numbers();
			var array = collect.ToMasiv();
			for (int i = 0; i < length - 1; i++)
			{
				for (int j = i + 1; j > 0; j--)
				{
					if (key(array[j - 1]).CompareTo(key(array[j])) > 0)
					{
						U temp = array[j - 1];
						array[j - 1] = array[j];
						array[j] = temp;
					}
				}
			}
			return array;

		}
		public static IEnumerable<T> MyDistinct<T>(this IEnumerable<T> collect)
		{
			// функція  Distinct вертає унікальні елементи колекції collect
			var list = new List<T>();
			foreach (var item in collect)
			{
				if (!HaveItem(list, item))
				{
					list.Add(item);
				}
			}

			return list;
		}

		private static bool HaveItem<T>(IEnumerable<T> values, T value)
		{
			foreach (var item in values)
			{
				if (item.Equals(value))
				{
					return true;
				}
			}
			return false;
		}

		// функція Range  генерує послідовність цілих чисел у заданому діапазоні.
		public static IEnumerable<int> Range(int first, int end)
		{
			var result = new List<int>();
			for (int i = first; i <= end; i++)
			{
				result.Add(i);
			}
			return result;
		}

		public static V Agregat<U, V>(this IEnumerable<U> collect, Func<U, V> key, Func<V, V, V> agregat)
		{
			// функція Agregat застосовує до колекції collect  агрегатну функцію agregat(sum, max, min, avg і тд). Результатом є сума, максимум, мінімум, середнє значення колекції, або певного її поля.;
			var changedCollect = new List<V>();
			foreach (var item in collect)
			{
				changedCollect.Add(key(item));
			}

			V buffer = agregat(changedCollect[0], changedCollect[1]);

			for (int i = 2; i < changedCollect.Count; i++)
			{
				buffer=agregat(buffer, changedCollect[i]);
			}

			return buffer;
		}

	}
}