"use strict";
var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (k !== "default" && Object.prototype.hasOwnProperty.call(mod, k)) __createBinding(result, mod, k);
    __setModuleDefault(result, mod);
    return result;
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.apiErrorHandler = exports.unCoughtErrorHandler = void 0;
var winston = __importStar(require("winston"));
var file = new winston.transports.File({
    filename: '../logs/error.log',
    level: 'error',
    handleExceptions: true,
});
function unCoughtErrorHandler(err, req, res, next) {
    winston.error(JSON.stringify(err));
    res.end({ error: err });
}
exports.unCoughtErrorHandler = unCoughtErrorHandler;
function apiErrorHandler(err, req, res, message) {
    var error = { Message: message, Request: req, Stack: err };
    winston.error(JSON.stringify(error));
    res.json({ Message: message });
}
exports.apiErrorHandler = apiErrorHandler;
