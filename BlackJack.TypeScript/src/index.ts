import { Application, urlencoded, json } from 'express';
import * as fs from 'fs';
import { WriteStream } from 'fs';
import * as path from 'path';

import Routes from './routes';

// app.enable('trust proxy'); // only if you're behind a reverse proxy (Heroku, Bluemix, AWS ELB, Nginx, etc)

export default class Server {
  constructor(app: Application) {
    this.config(app);
    new Routes(app);
  }

  public config(app: Application): void {
    const accessLogStream: WriteStream = fs.createWriteStream(
      path.join(__dirname, './logs/access.log'),
      { flags: 'a' }
    );
   
    app.use(urlencoded({ extended: true }));
    app.use(json());
   
    // PORT
   //const port = process.env.PORT || 3000;
  
  }
}



