﻿namespace Infrastructure.Verticals.Notifications;

public interface INotificationFactory
{
    List<INotificationProvider> OnFailedImportStrikeEnabled();
    
    List<INotificationProvider> OnStalledStrikeEnabled();
    
    List<INotificationProvider> OnSlowStrikeEnabled();
    
    List<INotificationProvider> OnQueueItemDeletedEnabled();

    List<INotificationProvider> OnDownloadCleanedEnabled();
}