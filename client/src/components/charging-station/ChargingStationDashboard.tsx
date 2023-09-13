import { useEffect, useState } from 'react';
import './ChargingStationDashboard.css';
import { ChargingStation, fetchStations } from '../api-station';
import Header from '../header/Header';
import { ChargingStationLocation, fetchLocations } from '../api-location';
import ChargingStationList from './ChargingStationList';

  function ChargingStationDashboard() {
    const [stations, setStations] = useState<ChargingStation[]>([]);
    const [locations, setLocations] = useState<ChargingStationLocation[]>([]);

    useEffect(() => {
      fetchStations().then((response) => {
        setStations(response.data); 
      });
      fetchLocations().then((response) => {
        setLocations(response.data);
      });
    }, []);

    return (
      <div>
        <Header />
  
        <ChargingStationList stations={stations} locations={locations} /> 
    </div>
    );
  }

  export default ChargingStationDashboard;
