import { Request, Response, NextFunction } from 'express';
import {GameRepository} from './../repositories/GameRepository';
import {CardDeskRepository} from './../repositories/CardDeskRepository';
import { apiErrorHandler } from './../handlers/errorHandler';

export default class GameController {
    
    constructor() { }
  
    async getAllCard(req: Request, res: Response, next: NextFunction) {
      try {
        const cards = await CardDeskRepository.getAllCard();
        res.json(cards);
      } catch (error) {
        apiErrorHandler(error, req, res, 'Fetch All Courses failed.');
      }
    }
    async startGame(req: Request, res: Response, next: NextFunction) {
        try {
            const cards = await GameRepository.StartGame();
            res.json(cards);
          } catch (error) {
            apiErrorHandler(error, req, res, 'Fetch All Courses failed.');
          }
    }
   
  
  }