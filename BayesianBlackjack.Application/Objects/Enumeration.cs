using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BayesianBlackjack.Application.Objects;
/// <summary>
///		An abstract class used to build enumeration classes.
/// </summary>
public abstract class Enumeration : IComparable
{
	public int Ordinal { get; }
	public string Name { get; }

	private static int _count = 0;
	/// <summary>
	///		An enumeration class has a unique ordinal value representing its place in
	///		its order of declaration of similar enumeration types and a given name.
	/// </summary>
	/// <param name="name">
	///		Enumeration instance name - displayed by ToString()
	/// </param>
	public Enumeration(string name)
	{
		Ordinal = _count++;
		Name = name;
	}

	public IEnumerable<T> ViewAll<T>() where T : Enumeration
	{
		Type type = typeof(T);
		FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

		return fields.Select(f => f.GetValue(null)).Cast<T>();
	}

	public int CompareTo(object? obj)
	{
		if(obj == null)
		{
			throw new ArgumentNullException(nameof(obj));
		}
		else if(GetType().Equals(obj.GetType()))
		{
			throw new ArgumentException(nameof(obj));
		}
		return Ordinal.CompareTo(((Enumeration)obj).Ordinal);
	}

	public override bool Equals(object? obj)
	{
		return CompareTo(obj) == 0;
	}

	public override int GetHashCode()
	{
		return Ordinal.GetHashCode();
	}

	public override string ToString()
	{
		return Name;
	}
}
