export class GameCustomModel{
   dealer : any; 
   player :  any;

   constructor({ dealer, player}: { dealer?: any; player?: any} = {}) {
    this.dealer = dealer;
    this.player = player;
 
   }

}