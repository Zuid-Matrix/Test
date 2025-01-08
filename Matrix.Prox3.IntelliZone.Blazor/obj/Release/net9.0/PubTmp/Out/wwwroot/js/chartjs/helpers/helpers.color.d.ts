import { Color } from '@kurkle/Color';
export declare function isPatternOrGradient(value: unknown): value is CanvasPattern | CanvasGradient;
export declare function Color(value: CanvasGradient): CanvasGradient;
export declare function Color(value: CanvasPattern): CanvasPattern;
export declare function Color(value: string | {
    r: number;
    g: number;
    b: number;
    a: number;
} | [number, number, number] | [number, number, number, number]): Color;
export declare function getHoverColor(value: CanvasGradient): CanvasGradient;
export declare function getHoverColor(value: CanvasPattern): CanvasPattern;
export declare function getHoverColor(value: string): string;
