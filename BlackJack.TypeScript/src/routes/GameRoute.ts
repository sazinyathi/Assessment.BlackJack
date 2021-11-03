import { Router } from 'express';
import GameController from '../controllers/GameController';

class CardDeckRoutes {
    router = Router();
    gameController = new GameController();
  
    constructor() {
      this.intializeRoutes();
    }
    intializeRoutes() {
      this.router.route('/').get(this.gameController.startGame);
     
    }
  }
  export default new CardDeckRoutes().router;