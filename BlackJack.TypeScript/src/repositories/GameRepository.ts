import { CardDeck } from "../models/CardDeck";
import { GameCustomModel } from "../models/GameCustomModel";
import { Hand } from "../models/Hand";
import { CardDeskRepository } from "./CardDeckRepository";


 class GameRepository{
 
    cardDeckRepository!: CardDeskRepository;
    player!: CardDeck;
    dealer!: CardDeck;

    constructor( ) {
       this.cardDeckRepository = new CardDeskRepository();      
       this.player = new CardDeck(0,'Player');
       this.dealer = new CardDeck(0,'Dealer')
    }

    gameCustomModel: any StartGame(): any{
       
        const playerCards: Array<Hand> = new Array();
        const dealerCards: Array<Hand> = new Array();
        
        playerCards.push(this.cardDeckRepository.drawCard(this.player));
        playerCards.push(this.cardDeckRepository.drawCard(this.player));
        dealerCards.push(this.cardDeckRepository.drawCard(dealer));
        dealerCards.push(this.cardDeckRepository.drawCard(dealer));
        var model = new GameCustomModel()
       
            model.dealer = dealerCards,
            model.player  = playerCards
        
        return model;
    }


}
export default new GameRepository();