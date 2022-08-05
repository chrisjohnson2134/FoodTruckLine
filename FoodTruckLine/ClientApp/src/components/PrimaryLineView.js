import React, { Component } from 'react';
import LineMemberTable from './functional/LineMembersTable';
export class Line extends Component {

    constructor(props) {
        super(props);
        this.state = { NowServingMembers: [], WaitingMembers: [], loading: true };
    }

    componentDidMount() {
        this.populateNameList();
    }

    render() {
        return (
            <div>
                <LineMemberTable lineName="Now Serving" lineMembers={this.state.NowServingMembers} />
                <LineMemberTable lineName="Currently Waiting" lineMembers={this.state.WaitingMembers} />
            </div>
        );
    }

    async populateNameList() {
        const response = await fetch(`line/NowServing`);
        const data = await response.json();
        console.log(data);
        this.setState({ NowServingMembers: data, loading: false });

        const response2 = await fetch(`line/CurrentWaiting`);
        const data2 = await response2.json();
        console.log(data);
        this.setState({ WaitingMembers: data2, loading: false });
    }
}
