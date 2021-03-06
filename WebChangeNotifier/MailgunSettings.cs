﻿namespace WebChangeNotifier
{
    public class MailgunSettings
    {
        public string ApiKey { get; set; }
        public string Domain { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; } = "WebChangeNotifier";

        public override string ToString()
        {
            return $"{nameof(ApiKey)}: {ApiKey}, {nameof(Domain)}: {Domain}, {nameof(From)}: {From}, {nameof(To)}: {To}, {nameof(Subject)}: {Subject}";
        }
    }
}