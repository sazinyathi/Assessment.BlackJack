import {CardDeck} from '../models/CardDeck'
import { Suit } from '../models/Suit';
import { Value } from '../models/Value';
import { Card } from '../models/Card';

 class CardDeskRepository {
  
    cards: Array<Card> ;
    constructor() {
        this.cards = this.CreateCards();
        
    }

     getAllCard()  {
        return this.cards;
      }
       
    CardTotals(cardNumber: number[]): number {
        return cardNumber.reduce((a, b) => a + b);
    }
    
    CreateCards() {
      const objCard: Array<Card> = new Array(); 
      let count : number = 0;
      for (let suit in Suit) {
	  for (let value in Value) {
      let card = new Card(count, value, suit);
      objCard.push(card);
      count = count + 1;
             }
          }
          return objCard;
      }    
    
        drawCard(cardDeck: CardDeck) {
        let selectId: number = this.selectRandomCard();
        return this.cards.find(x => x.cardId == selectId);
      }
    
        toString(){
        let results = '';
        for (let i: number = 0; (i < this.cards.length); i++) {
            results = (`${results} ${this.cards[i]}`);
        }
        return results;
    }
    
    private convertToInteger(cardName: string): number {
        let totalValue: number = 0;
        switch (cardName) {
            case "TWO":
                totalValue = (totalValue + 2);
                break;
            case "THREE":
                totalValue = (totalValue + 3);
                break;
            case "FOUR":
                totalValue = (totalValue + 4);
                break;
            case "FIVE":
                totalValue = (totalValue + 5);
                break;
            case "SIX":
                totalValue = (totalValue + 6);
                break;
            case "SEVEN":
                totalValue = (totalValue + 7);
                break;
            case "EIGHT":
                totalValue = (totalValue + 8);
                break;
            case "NINE":
                totalValue = (totalValue + 9);
                break;
            case "TEN":
                totalValue = (totalValue + 10);
                break;
            case "JACK":
                totalValue = (totalValue + 10);
                break;
            case "QUEEN":
                totalValue = (totalValue + 10);
                break;
            case "KING":
                totalValue = (totalValue + 10);
                break;
            case "ACE":
                totalValue = (totalValue + 10);
                break;
        }
        
        return totalValue;
    }
    
    private selectRandomCard(): number {
        const min :number = 0;
        return Math.floor(Math.random() * (this.cards.length - min)) + min;
        
    }
}

export default new CardDeskRepository();