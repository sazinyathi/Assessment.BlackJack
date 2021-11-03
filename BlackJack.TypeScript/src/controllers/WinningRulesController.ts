import { Request, Response, NextFunction } from 'express';
import {WinningRulesRepository} from './../repositoriesrepositories/WinningRulesRepository';
import { apiErrorHandler } from '../handlers/errorHandler';

export default class WinningRulesController {
    startGame(startGame: any) {
        throw new Error('Method not implemented.');
    }
    constructor() { }
  
    async toString(req: Request, res: Response, next: NextFunction) {
      try {
        const cards = await WinningRulesRepository.isPlayerHasAceAndPontoon();
        res.json(cards);
      } catch (error) {
        apiErrorHandler(error, req, res, 'Failed to Validate IsPlayerHasAceAndPontoon.');
      }
    }

   
  
  }