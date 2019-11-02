namespace Sentiment.Application

module UseCase =
    open System
    open Sentiment.Application.Dto
    
    
    let classifyText(text: String): Result<ClassificationResult, ApplicationError> =
        Error(UnknownError)

