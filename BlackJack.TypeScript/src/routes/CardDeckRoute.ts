import { Router } from 'express';
import CardDeskController from '../controllers/CardDeskController';

class CardDeckRoutes {
    router = Router();
    cardDeskController = new CardDeskController();
  
    constructor() {
      this.intializeRoutes();
    }
    intializeRoutes() {
      this.router.route('/').get(this.cardDeskController.getAllCard);
     
    }
  }
  export default new CardDeckRoutes().router;