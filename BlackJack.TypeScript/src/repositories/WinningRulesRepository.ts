import { Hand } from '../models/Hand';
import { HandCustomModel } from '../models/HandCustomModel';
import {WinningRules} from '../models/WinningRules'

 class WinningRulesRepository{

    constructor() { }

      isPlayerHasAceAndPontoon(player :Hand){
          const aceAndPontoon : string ='A';
          const winningRules = new  WinningRules();

          if(player.name == aceAndPontoon )
          {
              winningRules.isPlayerHasAceAndPontoon = true;
          }
          return winningRules;

      }

      isPlayerHasFiveTurn(player:Hand) {
             const numberOfTurns : number = 5;
             const busts : number = 21;
            var winningRules = new WinningRules();
            if (player.numberOfTurnsPlayed == numberOfTurns && player.total < busts)
                winningRules.isPlayerHasFiveTurn = true;
            return winningRules;
        }

        isBlackJack(handCustomModel : HandCustomModel)  {
            const busts : number = 21;
            var businessRules = new WinningRules();
            if (handCustomModel.player.Total == busts)
            {
                businessRules.isPlayerBlackJack = true;
            }
            if (handCustomModel.dealer.Total == busts)
            {
                businessRules.isTie = true;
                businessRules.isDealerBlackJack = true;
            }

            return businessRules;
          }

          isBusts(handCustomModel : HandCustomModel ) {
               const busts : number = 21;
              var businessRules = new WinningRules();
              if (handCustomModel.dealer.Total > busts && handCustomModel.player.Total < busts)
              {
                  businessRules.isDealerBusts = true;
              }
  
              if (handCustomModel.dealer.Total < busts)
              {
                  businessRules.isPlayerBusts = true;
              }
              return businessRules;
          }
  
          isCloseToBlackJack( handCustomModel : HandCustomModel ){
              const closeToBlackJack : number = 20;
              const busts : number = 21;
              var businessRules = new WinningRules();
              if (handCustomModel.player.Total == closeToBlackJack && handCustomModel.player.Total < busts)
              {
                  businessRules.isPlayerCloseToBlackJack = true;
              }
  
              if (handCustomModel.dealer.Total == closeToBlackJack && handCustomModel.dealer.Total < busts)
              {
                  businessRules.isDealerCloseToBlackJack = true;
              }
              return businessRules;
          }

}


export default new WinningRulesRepository();