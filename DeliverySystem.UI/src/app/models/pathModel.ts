export class FoundPathResult{
    totalTime: number;
    totalImportanceRate: number;
    path: PathLocality[];
}

class PathLocality{
    name: string;
    latitude: number;
    longitude: number;
    order: number;
}