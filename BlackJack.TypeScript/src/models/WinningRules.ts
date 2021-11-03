import { Model } from "sequelize/types";


export class WinningRules {
    isPlayerBlackJack: any;
    isTie: any;
    isDealerBlackJack: any;
    isDealerBusts: any;
    isPlayerBusts: any;
    isPlayerCloseToBlackJack: any;
    isDealerCloseToBlackJack: any;
    isPlayerHasAceAndPontoon: any;
    isPlayerHasFiveTurn: any;
   

    constructor(isPlayerBlackJack ?: any, isTie ?: any, isDealerBlackJack ?: any, isDealerBusts ?: any
          ,isPlayerBusts ?: any, isPlayerCloseToBlackJack ?: any, isDealerCloseToBlackJack?: any, isPlayerHasAceAndPontoon?: any 
          , isPlayerHasFiveTurn?: any
          )
        { this.isPlayerBlackJack = isPlayerBlackJack;
        this.isTie = isTie;
        this.isDealerBlackJack = isDealerBlackJack;
        this.isDealerBusts = isDealerBusts;
        this.isPlayerBusts = isPlayerBusts;
        this.isPlayerCloseToBlackJack = isPlayerCloseToBlackJack,
        this.isDealerCloseToBlackJack = isDealerBlackJack,
        this.isPlayerHasAceAndPontoon = isPlayerHasAceAndPontoon;
        this.isPlayerHasFiveTurn = isPlayerHasFiveTurn

}

}