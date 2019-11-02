namespace Sentiment.Application.Dto

type Emotion = Positive | Negative | Neutral

type ApplicationError =
    | UnknownError

type ClassificationResult = { Emotion: Emotion }