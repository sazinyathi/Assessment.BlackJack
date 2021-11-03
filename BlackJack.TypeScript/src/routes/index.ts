import { Application } from 'express';
import cardDeckRoute from './CardDeckRoute';
import gameRoute from './GameRoute';

export default class Routes {

  constructor(app: Application) {
    // course cardDeck
    app.use('/api/cardDesk', cardDeckRoute);
    // lesson routes
    app.use('/api/Game', gameRoute);
  }
}