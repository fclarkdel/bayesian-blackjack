using BayesianBlackjack.Application.Actors.Interfaces;
using BayesianBlackjack.Application.Objects;
using BayesianBlackjack.Application.Objects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BayesianBlackjack.Application.Actors;
/// <summary>
///		Represents a player in a game of blackjack. Handles all mathematical
///		and statistic calculations and measures on this player's hand.
/// </summary>
public class Player : IPlayer
{
	public IHand Hand { get; }

	public Player()
	{
		Hand = new Hand();
	}
	/// <summary>
	///		Calculates probability this player's hand will bust upon the next
	///		card drawn.
	/// </summary>
	/// <returns>
	///		The probability that this player's hand will bust upon the next
	///		card draw.
	/// </returns>
	public double CalcProbToBust()
	{
		const int HAND_VALUE_LIMIT = 21;
		const int UNIQUE_CARD_RANKS = 13;

		int handValue = 0;
		foreach(ICard card in Hand.View())
		{
			handValue += card.Value;
		}
		int minCardValueToBust = (HAND_VALUE_LIMIT - handValue) + 1;

		int cardsAboveMinValue = 0;
		foreach(int cardValue in Card.PossibleValues())
		{
			if(cardValue >= minCardValueToBust)
			{
				++cardsAboveMinValue;
			}
		}
		return cardsAboveMinValue / (double)UNIQUE_CARD_RANKS;
	}
	/// <summary>
	///		Calculates and returns the binomial distribution for a given probability
	///		and given number of trials.
	/// </summary>
	/// <returns>
	///		List of trial results.
	/// </returns>
	public List<Result> BinomialDistribution()
	{
		double p = CalcProbToBust();
		int n = 25;

		List<Result> results = new();
		for(int i = 0; i <= n; i++)
		{
			decimal ps = (decimal)Math.Pow(p, i);
			decimal pf = (decimal)Math.Pow(1 - p, n - i);
			decimal pk = p == 0 ? 0 : (decimal)Choose(n, i) * ps * pf;

			results.Add(new Result((pk), i));
		}
		return results;
	}
	/// <summary>
	///		Calculates a combination.
	/// </summary>
	/// <param name="n">
	///		Total number of elements.
	/// </param>
	/// <param name="k">
	///		Elements to choose from total.
	/// </param>
	/// <returns>
	///		Total number of ways to choose k elements from n total elements.
	/// </returns>
	private static double Choose(int n, int k)
	{
		int ret = 1;
		for(int i = 1; i <= k; ++i)
		{
			ret *= n--;
			ret /= i;
		}
		return ret;
	}
}
