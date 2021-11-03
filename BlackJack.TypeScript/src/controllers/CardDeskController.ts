import { Request, Response, NextFunction } from 'express';
import {CardDeskRepository} from './../CardDeckRepository';
import { apiErrorHandler } from './../handlers/errorHandler';

export default class CardDeskController {
    constructor() { }
  
    async getAllCard(req: Request, res: Response, next: NextFunction) {
      try {
        const cardList = await CardDeskRepository.getAllCard();
        res.json(cardList);
      } catch (error) {
        apiErrorHandler(error, req, res, 'Fetch All Card failed.');
      }
    }

   
  
  }