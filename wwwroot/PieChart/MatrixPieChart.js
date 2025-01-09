import React, { useEffect, useState, useRef } from 'react';

import PropTypes from 'prop-types';
import './MatrixPieChart.css';

const MatrixPieChart = props => {
    const [offsetMax, setOffsetMax] = useState(0);
    const [offsetMin , setOffsetMin] = useState(0);
    const [offsetAvg, setOffsetAvg] = useState(0);
    const circleRefMax = useRef(null);
    const circleRefAvg = useRef(null);
    const circleRefMin  = useRef(null);
    const { 
        size, 
        progressMax, 
        progressAvg,
        progressMin,
        maxValue,
        strokeWidthper, 
        bgStroke, 
        maxStroke,
        avgStroke,
        minStroke,
        gap,
        text
    } = props;
   
   // maxValue = maxValue ? maxValue : 0;
    const leftOffset = 20;
    const textboxWidth =0.15*size;
    const textboxHeight =0.1*size;
    const strokeWidth = Math.floor(size*strokeWidthper/100)
    const center = size/2 ;
    const radiusMax = size / 2 - strokeWidth / 2 - textboxWidth*0.6;
    const radiusAvg= radiusMax - strokeWidth - gap;
    const radiusMin = radiusAvg - strokeWidth -gap;
    const circumferenceMax = 2 * Math.PI * radiusMax;
    const circumferenceAvg = 2 * Math.PI * radiusAvg;
    const circumferenceMin = 2 * Math.PI * radiusMin;
    const shadow = 4;
    const x = -90;
    const y =0;
    const z = 0;
    const breakPoint = 0.4*maxValue
    const textboxMinX = 0;
    const textboxMinY = 0;
    const textboxAvgX = size-textboxWidth-shadow;
    const textboxAvgY = 0.07*size;
    const textboxMaxX = size-textboxWidth-0.025*size;
    const textboxMaxY = size-textboxHeight-shadow;
    const lineXext = 0.05*size;

    //label offset
    const labelX = textboxWidth*0.1;
    const labelY = 0.03*size;

    //value offset
    const valueX = textboxWidth*0.1;
    const valueY = 0.09*size;

    //Ends
    const minEndX = (center-leftOffset)*Math

    //Line Marker
    const lineMarker = 0.95;

    const calcX = (value, radius, center) => 
    {
        return center + Math.sin(2*Math.PI*(value*0.75/maxValue))*(radius)

    }

    const calcY = (value, radius, center) => 
    {
        return center - Math.cos(2*Math.PI*(value*0.75/maxValue))*(radius)
    }

    
    useEffect(() => {
        if(progressMax <= maxValue)
        {
            const progressOffset = ((maxValue - progressMax) / maxValue)* circumferenceMax;
            setOffsetMax(progressOffset);
        }
        else{
            setOffsetMax(maxValue);
        }
        
        circleRefMax.current.style = 'transition: stroke-dashoffset 850ms ease-in-out;';
    }, [setOffsetMax, circumferenceMax, progressMax, offsetMax]);

    useEffect(() => {
        const progressOffset = ((maxValue - progressMin) / maxValue) * circumferenceMin;
        setOffsetMin(progressOffset);
        circleRefMin.current.style = 'transition: stroke-dashoffset 850ms ease-in-out;';
    }, [setOffsetMin, circumferenceMin, progressMin, offsetMin]);
    useEffect(() => {
        const progressOffset = ((maxValue - progressAvg) / maxValue) * circumferenceAvg;
        setOffsetAvg(progressOffset);
        circleRefAvg.current.style = 'transition: stroke-dashoffset 850ms ease-in-out;';
    }, [setOffsetAvg, circumferenceAvg, progressAvg, offsetAvg]);
    return (
        <>
   
            <svg
                className="svg" 
                width={size}
                height={size}
            >
                {/* MAX CIRCLE */}
                <circle
                    className="svg-circle-bg"
                    stroke={bgStroke}
                    cx={center-size}
                    cy={center-leftOffset}
                    r={radiusMax}
                    strokeWidth={strokeWidth}
                    transform={`rotate(${x} ${y} ${z})`}
                    
                />
                <circle
                    className="svg-circle"
                    ref={circleRefMax}
                    stroke={maxStroke}
                    cx={center-size}
                    cy={center-leftOffset}
                    r={radiusMax}
                    // pathRadius= {radius+1000}
                    strokeWidth={strokeWidth}
                    strokeDasharray={circumferenceMax}
                    strokeDashoffset={offsetMax }
                    transform={`rotate(${x} ${y} ${z})`}
                />
{/* AVG CIRCLE */}
<circle
                    className="svg-circle-bg"
                    stroke={bgStroke}
                    cx={center-size}
                    cy={center-leftOffset}
                    r={radiusAvg}
                    strokeWidth={strokeWidth}
                    transform={`rotate(${x} ${y} ${z})`}
                />
                <circle
                    className="svg-circle"
                    ref={circleRefAvg}
                    stroke={avgStroke}
                    cx={center-size}
                    cy={center-leftOffset}
                    r={radiusAvg}
                    // pathRadius= {radius+1000}
                    strokeWidth={strokeWidth}
                    strokeDasharray={circumferenceAvg}
                    strokeDashoffset={offsetAvg}
                    transform={`rotate(${x} ${y} ${z})`}
                />
{/* MIN CIRCLE */}
                <circle
                    className="svg-circle-bg"
                    stroke={bgStroke}
                    cx={center-size}
                    cy={center-leftOffset}
                    r={radiusMin}
                    strokeWidth={strokeWidth}
                    transform={`rotate(${x} ${y} ${z})`}
                />
                <circle
                    className="svg-circle"
                    ref={circleRefMin}
                    stroke={minStroke}
                    cx={center-size}
                    cy={center-leftOffset}
                    r={radiusMin}
                    // pathRadius= {radius+1000}
                    strokeWidth={strokeWidth}
                    strokeDasharray={circumferenceMin}
                    strokeDashoffset={offsetMin}
                    transform={`rotate(${x} ${y} ${z})`}
                   
                />
                {progressAvg != null  && progressMax != null && progressMin != null   ? (
                    <>
                                     <text 
                    x={`${center-leftOffset}`} 
                    y={`${center+textboxHeight/4}`} 
                    className="svg-circle-text">
                        {text}
                </text> 
                    </>
                )
            :
            (                 
                <>                    <text 
                x={`${center-leftOffset}`} 
                y={`${center+textboxHeight/4}`} 
                className="svg-circle-text">
                    {'No Data'}
            </text> 
                </>)
            }


                {/* Maximum */}
                {progressMax != null && (
                    progressMax > breakPoint ? (
                        <>
                        <rect className="svg-textblock" width={textboxWidth} height={textboxHeight} x={textboxMaxX} y={textboxMaxY} rx="5" ry="5" />
                        <text className="svg-label-text" x={textboxMaxX + labelX} y={textboxMaxY + labelY}   font-size={0.03*size}>Max</text>
                        <text className="svg-value-text"  x={textboxMaxX +valueX}  y={textboxMaxY + valueY} fill={maxStroke}  font-size={0.06*size}>{progressMax.toFixed(1)}</text>
                        <MatrixLine className='svg-line' x1={textboxMaxX}  y1={textboxMaxY+textboxHeight/2} x2={textboxMaxX -lineXext} y2={textboxMaxY+textboxHeight/2} />
                        <MatrixLine className='svg-line' x1={textboxMaxX -lineXext} y1={textboxMaxY+textboxHeight/2} x2={calcX(progressMax,radiusMax,center-leftOffset)} y2={calcY(progressMax,radiusMax,center)} />
                        </>
                    )
                    :
                    ( 
            
                        <>
                        <rect className="svg-textblock" width={textboxWidth} height={textboxHeight} x={textboxMaxX} y={textboxMaxY} rx="5" ry="5" />
                        <text className="svg-label-text" x={textboxMaxX + labelX} y={textboxMaxY + labelY}   font-size={0.03*size}>Max</text>
                        <text className="svg-value-text"  x={textboxMaxX +valueX}  y={textboxMaxY + valueY} fill={maxStroke}  font-size={0.06*size}>{progressMax.toFixed(1)}</text>
                        <MatrixLine className='svg-line' x1={textboxMaxX +textboxWidth/2 }  y1={textboxMaxY} x2={textboxMaxX +textboxWidth/2} y2={textboxMaxY-textboxHeight/2} />
                        <MatrixLine className='svg-line' x1={textboxMaxX + textboxWidth/2 } y1={textboxMaxY-textboxHeight/2} x2={calcX(progressMax,radiusMax,center-leftOffset)} y2={calcY(progressMax,radiusMax,center)} />
                        </>)
                    
                    )
            }
  
                {/* Minimum */}
                { progressMin != null ? ( 
                    <>
                <rect className="svg-textblock" width={textboxWidth} height={textboxHeight} x={textboxMinX} y={textboxMinY} rx="5" ry="5" />
                <text className="svg-label-text" x={textboxMinX + labelX} y={textboxMinY + labelY}  font-size={0.03*size}>Min</text>
                <text className="svg-value-text"  x={textboxMinX +valueX}  y={textboxMinY + valueY} fill={minStroke} font-size={0.06*size}>{progressMin.toFixed(1)}</text>
                <MatrixLine className='svg-line' x1={textboxMinX+textboxWidth}  y1={textboxMinY+textboxHeight/2} x2={textboxMinX+textboxWidth+lineXext} y2={textboxMinY+textboxHeight/2} />
                <MatrixLine className='svg-line' x1={textboxMinX+textboxWidth+lineXext} y1={textboxMinY+textboxHeight/2}  x2={calcX(progressMin,radiusMin,center-leftOffset)} y2={calcY(progressMin,radiusMin,center)} />
                </>
                ) : (<div></div>)}

                {/* Average */}
                { progressAvg != null? ( 
                    <>
                <rect className="svg-textblock" width={textboxWidth} height={textboxHeight} x={textboxAvgX} y={textboxAvgY} rx="5" ry="5" />
                <text className="svg-label-text" x={textboxAvgX + labelX} y={textboxAvgY + labelY}  font-size={0.03*size}>Avg</text>
                <text className="svg-value-text"  x={textboxAvgX +valueX}  y={textboxAvgY + valueY} fill={avgStroke}  font-size={0.06*size}>{progressAvg.toFixed(1)}</text>
                <MatrixLine className='svg-line' x1={textboxAvgX}  y1={textboxAvgY+textboxHeight/2} x2={textboxAvgX -lineXext} y2={textboxAvgY+textboxHeight/2} />
                
                <MatrixLine className='svg-line' x1={textboxAvgX -lineXext} y1={textboxAvgY+textboxHeight/2} x2={calcX(progressAvg,radiusAvg,center-leftOffset)} y2={calcY(progressAvg,radiusAvg,center)} />
                
                </>
                ) : (<></>)}
               
            </svg>

        </>
    )                                                                                                                                       
}



MatrixPieChart.propTypes = {
    size: PropTypes.number.isRequired,
    progressMax: PropTypes.number,
    progressAvg: PropTypes.number,
    progressMin: PropTypes.number,
    maxValue: PropTypes.number.isRequired,
    strokeWidthper: PropTypes.number.isRequired,
    bgStroke: PropTypes.string.isRequired,
    maxStroke: PropTypes.string,
    avgStroke: PropTypes.string,
    minStroke: PropTypes.string,
    gap: PropTypes.number.isRequired,
    text: PropTypes.string.isRequired
}

MatrixPieChart.defaultProps = {
    progressMax: null,
    progressMin: null,
    progressAvg: null,
    maxStroke:'#FF0000',
    minStroke:'#50B948',
    avgStroke:'#FFD966'
}

export default MatrixPieChart;