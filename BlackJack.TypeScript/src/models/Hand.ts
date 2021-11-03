

export class Hand {
    name :string;
    total :number;
    player :string;
    numberOfTurnsPlayed :number;

   constructor( name: string, total: number,  player: string, numberOfTurnsPlayed: number) {
    this.name = name;
    this.total = total;
    this.player = player;
    this.numberOfTurnsPlayed = numberOfTurnsPlayed; 
   }

}