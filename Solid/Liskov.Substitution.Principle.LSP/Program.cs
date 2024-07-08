
using Liskov.Substitution.Principle.LSP.Utils;

NubankCard card;


//card = new CreditCard();
card = new DebitCard();


card.Validate();
card.CollectPayment();
