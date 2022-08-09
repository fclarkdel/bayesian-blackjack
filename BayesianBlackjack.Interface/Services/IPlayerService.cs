using BayesianBlackjack.Application.Actors.Interfaces;
using BayesianBlackjack.Application.Objects;

namespace BayesianBlackjack.Interface.Services
{
	public interface IPlayerService
	{
		IPlayer Player { get; set; }

		event Action? OnChange;

		void AddCard(Card card);
		void RemoveCard(Card card);
	}
}